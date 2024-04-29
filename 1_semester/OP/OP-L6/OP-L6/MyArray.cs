using System;
namespace OP_L6
{
	public class MyArray
	{
        private int[,] myArray;
        Random rnd = new Random();

        public MyArray()
		{
            myArray = new int[1, 1];
		}

        public MyArray(int dim1,int dim2)
        {
            myArray = new int[dim1, dim2];
        }

        public void Filling()
        {
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = rnd.Next(-100, 100);
                }
            }
        }


        private int Summa(int x)
        {
            int s = 0;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                s += myArray[i, x];
            }
            return s;
        }



        public void BubbleSortUp()
        {
            for (int i = 1; i < myArray.GetLength(1); i++)
            {
                for (int j = 0; j < myArray.GetLength(1) - i; j++)
                {
                    if (Summa(j) > Summa(j+1))
                    {
                        int[] temp = new int[myArray.GetLength(0)];
                        for (int k = 0; k < myArray.GetLength(0); k++)
                        {
                            temp[k] = myArray[k,j];
                        }
                        for (int k = 0; k < myArray.GetLength(0); k++)
                        {
                            myArray[k, j] = myArray[k, j+1];
                        }
                        for (int k = 0; k < myArray.GetLength(0); k++)
                        {
                            myArray[k, j+1] = temp[k];
                        }
                    }
                }
            }
        }


        public void BubbleSortDown()
        {
            for (int i = 1; i < myArray.GetLength(1); i++)
            {
                for (int j = 0; j < myArray.GetLength(1) - i; j++)
                {
                    if (Summa(j) < Summa(j + 1))
                    {
                        int[] temp = new int[myArray.GetLength(0)];
                        for (int k = 0; k < myArray.GetLength(0); k++)
                        {
                            temp[k] = myArray[k, j];
                        }
                        for (int k = 0; k < myArray.GetLength(0); k++)
                        {
                            myArray[k, j] = myArray[k, j + 1];
                        }
                        for (int k = 0; k < myArray.GetLength(0); k++)
                        {
                            myArray[k, j + 1] = temp[k];
                        }
                    }
                }
            }
        }



        public void Info()
        {
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }

    }
}

