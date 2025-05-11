using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
	class InsertionSort : SortingAlgorithm
    {
        public override List<int> Sort(List<int> list)
        {
            List<int> tmp = new List<int>(list);
            List<int> result = new List<int>
            {
                tmp[0]
            };
            for (int i = 0; i < tmp.Count; i++)
            {
                for (int j = 0; j < result.Count; j++)
                {
                    if (tmp[i] < result[j])
                    {
                        result.Insert(j, tmp[i]);
                        break;
                    }
                    if (j == result.Count - 1)
                    {
                        result.Insert(j, tmp[i]);
                        break;
                    }
                }
            }
            result.RemoveAt(result.Count - 1);
            return result;
        }
    }
}
