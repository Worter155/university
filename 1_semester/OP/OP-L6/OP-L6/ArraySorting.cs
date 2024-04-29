using System;
namespace OP_L6
{
	public class ArraySorting
	{
		private int[] myArray;

		public ArraySorting()
		{
			myArray = new int[1];
		}

		public ArraySorting(int dim)
        {
			myArray = new int[dim];
        }

		public void Filling()
		{

			for (int i = 0; i < myArray.Length; i++)
			{
				Console.Write($"{i + 1} элемент: ");
				myArray[i] = int.Parse(Console.ReadLine());
			}
		}

        public void BubbleSort()
        {
            for (int i = 1; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length - i; j++)
                {
                    if (myArray[j] > myArray[j + 1])
                    {
                        int temp = myArray[j];
                        myArray[j] = myArray[j + 1];
                        myArray[j + 1] = temp;
                    }
                }
            }
        }

        public void ShellSort()
        {
            int d = myArray.Length / 2;
            while (d >= 1)
            {
                for (int i = d; i < myArray.Length; i++)
                {
                    int j = i;
                    while ((j >= d) && (myArray[j - d] > myArray[j]))
                    {
                        int temp = myArray[j];
                        myArray[j] = myArray[j-d];
                        myArray[j - d] = temp;
                        j -= d;
                    }
                }

                d = d / 2;
            }
        }

        public void SelectionSort()
        {
            int min, temp;
            for (int i = 0; i < myArray.Length; i++)
            {
                min = i;
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[j] < myArray[min])
                    {
                        min = j;
                    }
                }
                temp = myArray[min];
                myArray[min] = myArray[i];
                myArray[i] = temp;
            }
        }

        public void Info()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]} ");
            }
            Console.WriteLine();
        }
    }
}

