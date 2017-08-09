using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RollPlay.Services;
using RollPlay.Utilities;

namespace RollPlay.Tests.ServiceTests
{
    [TestClass]
    public class RollControllerTests
    {
        /// <summary>
        /// Tests to make sure the roller API is being instantiated and working correctly.
        /// </summary>
        [TestMethod]
        public void CanGetRolls()
        {
            var roller = new RollController(new DiceRoller());

            var result = roller.Get(1);

            result.ShouldBeEquivalentTo(1);
        }
    }
}