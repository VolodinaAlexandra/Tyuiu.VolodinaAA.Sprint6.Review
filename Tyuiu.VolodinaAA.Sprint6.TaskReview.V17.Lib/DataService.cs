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
            if (k < 0 || l < k || c < 0 || c >= array.GetLength(0)|| n1>=n2)
            {
                throw new ArgumentException("некорректные вводные данные");
            }
            int result = 1;
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j+=2)
                {
                    if(j>=k && j<=l)
                    {
                        result *= array[i,j];
                    }
                }
            }
            return result;
        }
    }
}
