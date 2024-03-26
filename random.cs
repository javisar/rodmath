using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace RodMath
{
    /// <summary>
    /// Random Number Generator based on xorshift.
    /// Designed for minimal state (32bits) to be easily embeddable into components.
    /// Core functionality is integer multiplication free to improve vectorization
    /// on less capable SIMD instruction sets.
    /// </summary>
    [Serializable]
    public partial struct Random
    {
        /// <summary>
        /// The random number generator state. It should not be zero.
        /// </summary>
        public uint state;

        /// <summary>
        /// Constructs a Random instance with a given seed value. The seed must be non-zero.
        /// </summary>
        /// <param name="seed">The seed to initialize with.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Random(uint seed)
        {
            state = seed;
            CheckInitState();
            NextState();
        }

        /// <summary>
        /// Constructs a <see cref="Random"/> instance with an index that gets hashed.  The index must not be uint.MaxValue.
        /// </summary>
        /// <remarks>
        /// Use this function when you expect to create several Random instances in a loop.
        /// </remarks>
        /// <example>
        /// <code>
        /// for (uint i = 0; i &lt; 4096; ++i)
        /// {
        ///     Random rand = Random.CreateFromIndex(i);
        ///
        ///     // Random numbers drawn from loop iteration j will be very different
        ///     // from every other loop iteration k.
        ///     rand.NextUInt();
        /// }
        /// </code>
        /// </example>
        /// <param name="index">An index that will be hashed for Random creation.  Must not be uint.MaxValue.</param>
        /// <returns><see cref="Random"/> created from an index.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Random CreateFromIndex(uint index)
        {
            CheckIndexForHash(index);

            // Wang hash will hash 61 to zero but we want uint.MaxValue to hash to zero.  To make this happen
            // we must offset by 62.
            return new Random(WangHash(index + 62u));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint WangHash(uint n)
        {
            // https://gist.github.com/badboy/6267743#hash-function-construction-principles
            // Wang hash: this has the property that none of the outputs will
            // collide with each other, which is important for the purposes of
            // seeding a random number generator.  This was verified empirically
            // by checking all 2^32 uints.
            n = (n ^ 61u) ^ (n >> 16);
            n *= 9u;
            n = n ^ (n >> 4);
            n *= 0x27d4eb2du;
            n = n ^ (n >> 15);

            return n;
        }

        /// <summary>
        /// Initialized the state of the Random instance with a given seed value. The seed must be non-zero.
        /// </summary>
        /// <param name="seed">The seed to initialize with.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InitState(uint seed = 0x6E624EB7u)
        {
            state = seed;
            NextState();
        }

        /// <summary>Returns a uniformly random bool value.</summary>
        /// <returns>A uniformly random boolean value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool NextBool()
        {
            return (NextState() & 1) == 1;
        }

        /// <summary>Returns a uniformly random int value in the interval [0, max).</summary>
        /// <param name="max">The maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random int value in the range [0, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int NextInt(int max)
        {
            CheckNextIntMax(max);
            return (int)((NextState() * (ulong)max) >> 32);
        }

        /// <summary>Returns a uniformly random int value in the interval [min, max).</summary>
        /// <param name="min">The minimum value to generate, inclusive.</param>
        /// <param name="max">The maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random integer between [min, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int NextInt(int min, int max)
        {
            CheckNextIntMinMax(min, max);
            uint range = (uint)(max - min);
            return (int)(NextState() * (ulong)range >> 32) + min;
        }

        /// <summary>Returns a uniformly random uint value in the interval [0, 4294967294].</summary>
        /// <returns>A uniformly random unsigned integer.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint NextUInt()
        {
            return NextState() - 1u;
        }


        /// <summary>Returns a uniformly random uint value in the interval [0, max).</summary>
        /// <param name="max">The maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random unsigned integer in the range [0, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint NextUInt(uint max)
        {
            return (uint)((NextState() * (ulong)max) >> 32);
        }


        /// <summary>Returns a uniformly random uint value in the interval [min, max).</summary>
        /// <param name="min">The minimum value to generate, inclusive.</param>
        /// <param name="max">The maximum value to generate, exclusive.</param>
        /// <returns>A uniformly random unsigned integer in the range [min, max).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint NextUInt(uint min, uint max)
        {
            CheckNextUIntMinMax(min, max);
            uint range = max - min;
            return (uint)(NextState() * (ulong)range >> 32) + min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private uint NextState()
        {
            CheckState();
            uint t = state;
            state ^= state << 13;
            state ^= state >> 17;
            state ^= state << 5;
            return t;
        }

        [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
        private void CheckInitState()
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
            if (state == 0)
                throw new System.ArgumentException("Seed must be non-zero");
#endif
        }

        [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
        static void CheckIndexForHash(uint index)
        {
            if (index == uint.MaxValue)
                throw new System.ArgumentException("Index must not be uint.MaxValue");
        }

        [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
        private void CheckState()
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
            if(state == 0)
                throw new System.ArgumentException("Invalid state 0. Random object has not been properly initialized");
#endif
        }

        [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
        private void CheckNextIntMax(int max)
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
            if (max < 0)
                throw new System.ArgumentException("max must be positive");
#endif
        }

        [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
        private void CheckNextIntMinMax(int min, int max)
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
            if (min > max)
                throw new System.ArgumentException("min must be less than or equal to max");
#endif
        }

        [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
        private void CheckNextUIntMinMax(uint min, uint max)
        {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
            if (min > max)
                throw new System.ArgumentException("min must be less than or equal to max");
#endif
        }

    }
}
