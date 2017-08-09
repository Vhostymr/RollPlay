using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RollPlay.Utilities;
using System;

namespace RollPlay.Tests.UtilityTests
{
    [TestClass]
    public class DiceRollerTests
    {
        /// <summary>
        /// Tests to make sure the dice roller is working at all.
        /// 
        /// Necessary as a stricter test than RollIsInRange.
        /// </summary>
        [TestMethod]
        public void CanRollDice()
        {
            var roller = new DiceRoller();

            var result = roller.Roll(1);

            result.ShouldBeEquivalentTo(1);
        }

        /// <summary>
        /// Tests to make sure the dice roller is within the expected range.
        /// </summary>
        [TestMethod]
        public void RollIsInRange()
        {
            var roller = new DiceRoller();

            var result = roller.Roll(100);

            result.Should().BeInRange(1, 100);
        }

        /// <summary>
        /// Tests to make sure the dice roller is working at all.
        /// 
        /// Necessary as a stricter test than RollIsInRange.
        /// </summary>
        [TestMethod]
        public void RollIsOutOfRange()
        {
            var roller = new DiceRoller();

            //Test if max is less than 0.
            roller.Invoking(f => f.Roll(-1)).ShouldThrow<ArgumentOutOfRangeException>();

            //Test if min is less than 0.
            roller.Invoking(f => f.Roll(100, -1)).ShouldThrow<ArgumentOutOfRangeException>();

            //Test if max is less than min. (Default min is 1).
            roller.Invoking(f => f.Roll(1, 5)).ShouldThrow<ArgumentOutOfRangeException>();
        }
    }
}