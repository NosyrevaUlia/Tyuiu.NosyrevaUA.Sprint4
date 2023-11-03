﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NosyrevaUA.Sprint4.Task0.V6.Lib
{
    public class DataService : ISprint4Task0V6
    {
        public int GetSumOddArrEl(int[] array)
        {
            int c = 0;
            for (int i = 0; i <= array.Length-1; i++ )
            {
                if (array[i] % 2 == 1)
                {
                    c += array[i];
                }
            }
            return c;
        }
    }
}
