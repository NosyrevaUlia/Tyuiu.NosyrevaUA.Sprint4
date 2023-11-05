using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NosyrevaUA.Sprint4.Task3.V21.Lib
{
    public class DataService : ISprint4Task3V21
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0);
           
            int c = 1;
            for (int i = 0; i <= rows; i++)
            {
                c = c * array[i, 4];
            }
            return c;
        }
    }
}
