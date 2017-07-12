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

        public int Roll(int max, int min = 1)
        {
            lock (_syncLock) // synchronize for multithread.
            {
                return _random.Next(min, max);
            }
        }
    }
}