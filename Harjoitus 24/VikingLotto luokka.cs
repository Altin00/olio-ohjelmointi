using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_24
{
    internal class VikingLotto_luokka
    {
    }
}


namespace LotteryApp.Models
{
    public class VikingLotto
    {
        private static Random random = new Random();

        public List<int> GenerateRow()
        {
            return GenerateNumbers(6, 1, 48);
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
