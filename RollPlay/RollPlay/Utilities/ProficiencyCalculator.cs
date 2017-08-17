using System;

namespace RollPlay.Utilities
{
    public class ProficiencyCalculator : IProficiencyCalculator
    {
        /// <summary>
        /// Returns the proficiency bonus based on character level and a modifier from skills or abilities.
        /// </summary>
        /// <param name="characterLevel">The character's level.</param>
        /// <param name="modifier">The skill or ability modifer. Usually normal, half, or double.</param>
        /// <returns>An integer calculation of proficiency, rounded down.</returns>
        public int GetProficiencyBonus(int characterLevel, double modifier = 1)
        {
            if (characterLevel < 1) throw new ArgumentOutOfRangeException(nameof(characterLevel), "A character's level cannot be less than 1.");
            if (modifier < 0) throw new ArgumentOutOfRangeException(nameof(modifier), "The proficiency modifer cannot be negative.");

            const int threshold = 5;
            const int minimum = 2;

            //The proficiency bonus changes every 5th level, so add the new threshold increase plus the minimum at that point. 
            //Also, calculate the modifier from abilities or skills.
            return (int)Math.Floor((characterLevel / threshold + minimum) * modifier);
        }
    }
}