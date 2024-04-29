using System;

namespace OP_L6
{
	public class StepArray
	{
        public int[][] arr;
        public StepArray(int line, int[] column)
        {
            arr = new int[line][];
            for (int i = 0; i < line; i++)
            {
                arr[i] = new int[column[i]];
            }
        }

        public void Filling()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"Введите элемент ступенчатого массива [{i}][{j}]: ");
                    arr[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
        }

        public void Info()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static int[] BubbleSort(int[] myArray)
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
            return myArray;
        }

        public void StepSort()
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    count++;
                }
            }
            int[] newarr = new int[count];
            int el = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    newarr[el] = arr[i][j];
                    el++;
                }
            }
            BubbleSort(newarr);
            el = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = newarr[el];
                    el++;
                }
            }
        }
    }
}

