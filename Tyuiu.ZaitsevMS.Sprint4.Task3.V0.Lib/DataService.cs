using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
 
namespace Tyuiu.ZaitsevMS.Sprint4.Task3.V4.Lib
{
    public class DataService : ISprint4Task3V4
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int lastCol = columns - 1;

            int min = matrix[0, lastCol];

            for (int i = 1; i < rows; i++)
            {
                if (matrix[i, lastCol] < min)
                {
                    min = matrix[i, lastCol];
                }
            }
            return min;
        }
    }
}