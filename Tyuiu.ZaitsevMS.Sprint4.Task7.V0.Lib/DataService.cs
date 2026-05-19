using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZaitsevMS.Sprint4.Task7.V26.Lib 
{
    public class DataService : ISprint4Task7V26
    {
        public int Calculate(int rows, int columns, string value)
        {
            int[,] mtrx = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * columns + j, 1));
                }
            }

            int product = 1;
            bool hasEven = false;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (mtrx[i, j] % 2 == 0)
                    {
                        product *= mtrx[i, j];
                        hasEven = true;
                    }
                }
            }

            return hasEven ? product : 0;
        }
    }
}