using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.VolodinaAA.Sprint6.TaskReview.V17.Lib
{
    public class DataService
    {
        public int GetMatrix(int[,] array, int n1, int n2, int c, int k, int l)
        {
            if (array.GetLength(0) <= 1 || array.GetLength(1) <= 1 || n1 >= n2 ||
                c < 0 || c >= array.GetLength(0) || k < 0 || k >= array.GetLength(1) ||
                l < 0 || l >= array.GetLength(1) || (l - k) % 2 != 0)
            {
                throw new ArgumentException("Некорректные входные данные");
            }

            int result = array[c, k];
            for (int i = k + 2; i <= l; i += 2)
            {
                if (n1 >= n2 || k >= l || array.GetLength(0) <= 1 || array.GetLength(1) <= 1)
                {
                    result = 0;
                }
                else
                {
                    result *= array[c, i];
                }
            }
            return result;
        }
    }
}
