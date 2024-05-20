using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_24
{
    internal class Eurojackpot_luokka
    {
    }
}


namespace LotteryApp.Models
{
    public class Eurojackpot
    {
        private static Random random = new Random();

        public (List<int> MainNumbers, List<int> StarNumbers) GenerateRow()
        {
            var mainNumbers = GenerateNumbers(5, 1, 50);
            var starNumbers = GenerateNumbers(2, 1, 10);
            return (mainNumbers, starNumbers);
        }

        private List<int> GenerateNumbers(int count, int min, int max)
        {
            return Enumerable.Range(min, max - min + 1)
                             .OrderBy(x => random.Next())
                             .Take(count)
                             .ToList();
        }
    }
}
