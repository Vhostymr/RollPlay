using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RollPlay.Utilities;
using System;

namespace RollPlay.Tests.UtilityTests
{
    [TestClass]
    public class ProficiencyTests
    {
        /// <summary>
        /// Tests to make sure the proficiency bonuses are being calculated correctly.
        /// </summary>
        [TestMethod]
        public void CanGetProficiencyBonus()
        {
            var proficiencyCalculator = new ProficiencyCalculator();

            //Base threshold.
            var result = proficiencyCalculator.GetProficiencyBonus(1);
            result.ShouldBeEquivalentTo(2);

            //Level 5 threshold.
            result = proficiencyCalculator.GetProficiencyBonus(5);
            result.ShouldBeEquivalentTo(3);

            //Level 10 threshold.
            result = proficiencyCalculator.GetProficiencyBonus(10);
            result.ShouldBeEquivalentTo(4);

            //Level 15 threshold.
            result = proficiencyCalculator.GetProficiencyBonus(15);
            result.ShouldBeEquivalentTo(5);

            //Level 20 threshold.
            result = proficiencyCalculator.GetProficiencyBonus(20);
            result.ShouldBeEquivalentTo(6);
        }

        /// <summary>
        /// Tests to make sure the proficiency calculator throws the correct exceptions if arguments are outside the expected range.
        /// </summary>
        [TestMethod]
        public void ProficiencyArgumentsOutOfRange()
        {
            var proficiencyCalculator = new ProficiencyCalculator();

            //Test if character level is less than 1.
            proficiencyCalculator.Invoking(f => f.GetProficiencyBonus(0)).ShouldThrow<ArgumentOutOfRangeException>();

            //Test if modifier is less than 0.
            proficiencyCalculator.Invoking(f => f.GetProficiencyBonus(20, -1)).ShouldThrow<ArgumentOutOfRangeException>();
        }
    }
}