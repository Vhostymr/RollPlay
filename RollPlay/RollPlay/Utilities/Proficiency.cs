using System;

namespace RollPlay.Utilities
{
    public class Proficiency
    {
        /// <summary>
        /// Returns the proficiency bonus based on character level and a modifier from skills or abilities.
        /// </summary>
        /// <param name="characterLevel">The character's level.</param>
        /// <param name="modifier">The skill or ability modifer. Usually normal, half, or double.</param>
        /// <returns>An integer calculation of proficiency, rounded down.</returns>
        public static int GetProficiencyBonus(int characterLevel, double modifier = 1)
        {
            const int threshold = 5;
            const int minimum = 2;

            //The proficiency bonus changes every 5th level, so add the new threshold increase plus the minimum at that point. 
            //Also, calculate the modifier from abilities or skills.
            return (int)Math.Floor((characterLevel / threshold + minimum) * modifier);
        }
    }
}