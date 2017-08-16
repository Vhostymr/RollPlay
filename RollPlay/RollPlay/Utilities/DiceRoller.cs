using System;

namespace RollPlay.Utilities
{
    public class DiceRoller : IDiceRoller
    {
        private static readonly Random _random;
        private static readonly object _syncLock;

        static DiceRoller()
        {
            _random = new Random();
            _syncLock = new object();
        }

        /// <summary>
        /// Rolls a many sided die of the value provided.
        /// </summary>
        /// <param name="max">The number of die faces.</param>
        /// <param name="min">The minimum possible value, default 1.</param>
        /// <returns>The dice value.</returns>
        public int Roll(int max, int min = 1)
        {
            if (max < 0) throw new ArgumentOutOfRangeException(nameof(max), "The max value cannot be lower than 0.");
            if (min < 0) throw new ArgumentOutOfRangeException(nameof(min), "The min value cannot be lower than 0.");
            if (max < min) throw new ArgumentOutOfRangeException(nameof(max), $"The max value cannot be lower than the minimum ({min}).");

            lock (_syncLock) // synchronize for multithread.
            {
                return _random.Next(min, max);
            }
        }
    }
}