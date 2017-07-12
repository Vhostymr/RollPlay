using RollPlay.Utilities;
using System.Web.Http;

namespace RollPlay.Services
{
    public class RollController : ApiController
    {
        private readonly IDiceRoller _roller;

        public RollController(IDiceRoller roller)
        {
            _roller = roller;
        }

        /// <summary>
        /// Returns the result of a many sided die of the provided value.
        /// </summary>
        /// <param name="id">The type of die to roll.</param>
        /// <returns>An integer value from min to the max provided.</returns>
        public int Get(int id = 20) //D20 by default Get command.
        {
            return _roller.Roll(id);
        }
    }
}