using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProtoFlipPizzaSystem.Models.Utils
{
    public static class DataGenerator
    {
        private static int idCounter;

        static DataGenerator()
        {
            idCounter = 0;
        }

        public static int GenerateId()
        {
            return Interlocked.Increment(ref idCounter);
        }
    }
}
