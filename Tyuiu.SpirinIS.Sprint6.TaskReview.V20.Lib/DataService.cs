using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tyuiu.MartysevichAD.Sprint6.TaskReview.V20.Lib
{
    public class DataService
    {
        public int GetMatrix(int[,] array, int n1, int n2, int r, int k, int l)
        {
            
            Random rnd = new Random();
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int[] arr = new int[columns];

            int res = 999999999;

           
            for (int j = 0; j < rows; j++)
            {
                if(array[r,j]<res)
                {
                     res = array[r, j];
                }
            }

            
            return res;
        }
    }
}
