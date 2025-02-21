using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello
{
    public class Pro1
    {

        // sum of diagonals element 
        public void Matrix()
        {
            int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            // Console.WriteLine(arr.Length);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine("[" + i + " " + j + "]" + "= " + arr[i, j]);
                    }
                }
            }
        }


        //  sum of 2 row in one row 
        public void Matrix1()
        {
            int[,] matrix = new int[4, 3]{
            {1,2,3},
            {4,5,6},
            {7,8,9},
            {10,11,12}};
            int[,] matrix1 = new int[2, 3];

            int i = 0, j = 1, k, l;

            for (k = 0; k < 2; k++, i = i + 2, j = j + 2)
            {
                for (l = 0; l < 3; l++)
                {
                    matrix1[k, l] = matrix[i, l] + matrix[j, l];
                }

            }

            for (int m = 0; m < 2; m++)
            {
                Console.Write("[");
                for (int n = 0; n < 3; n++)
                {
                    Console.Write(matrix1[m, n] + " ");
                }
                Console.Write("]");
                Console.WriteLine("");
            }




        }


        // sum of all row store in a array 
        public void Matrix2()
        {
            int[,] arr = new int[3, 3]{
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            int[] result = new int[3];
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum = sum + arr[i, j];
                }
                result[i] = sum;
                sum = 0;

            }
            Console.Write("[");
            for (int i = 0; i < result.Length; i++)
            {

                Console.Write(result[i] + " ");
            }
            Console.Write("]");
        }

        // calculate the sum fo all rows value and who have grater value 
        public void Matrix3()
        {
            int[,] arr = new int[3, 3]{
                {1,2,3},
                {4,5,6},
                {77,8,9}
            };
            int[] result = new int[3];
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum = sum + arr[i, j];
                }
                result[i] = sum;
                sum = 0;

            }

            int k;
            int largest = result[0];
            for (k = 1; k < result.Length; k++)
            {
                if (result[k] > largest)
                {
                    largest = result[k];
                }
            }

            Console.WriteLine(largest);

        }


        // reverse the matrix m*n = n*m

        public void Matrix4()
        {
            int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] arr1 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr1[j, i] = arr[i, j];

                }
            }

            // for print 
            Console.WriteLine("[ ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("[");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                // Console.Write("]");
                Console.WriteLine("]");
            }
            Console.Write("]");
        }


        // count numbers of 2*2 sub arrays made 
        public int Matrix5(int rows, int cols)
        {
            if (rows < 0 || cols < 0)
            {
                return 0;
            }
            else
            {
                return (rows - 1) * (cols - 1);
            }

        }
    }


}