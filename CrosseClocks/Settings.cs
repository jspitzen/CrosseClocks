using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrosseClocks
{
    static class Settings
    {
        /// <summary>
        /// The time in seconds each tick takes.
        /// </summary>
        public const double TICK_TIME = 0.01;

        /// <summary>
        /// The number of minutes in a quarter of the match.
        /// </summary>
        public const int MINUTES_PER_QUARTER = 20;
    }
}
