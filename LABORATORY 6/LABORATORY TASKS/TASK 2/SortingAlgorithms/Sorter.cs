using C6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class Sorter
    {
        private SortingAlgorithm strategy;

        public void SetAlgorithm(SortingAlgorithm strategyType)
        {
            strategy = strategyType;
        }

        public List<int> Sort(List<int> list)
        {
            return strategy.Sort(list);
        }
    }
}
