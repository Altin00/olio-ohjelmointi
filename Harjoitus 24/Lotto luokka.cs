using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_24
{
    internal class Lotto_luokka
    {
    }
}



namespace LotteryApp.Models
{
    public class Lotto
    {
        private static Random random = new Random();

        public List<int> GenerateRow()
        {
            return GenerateNumbers(7, 1, 40);
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

