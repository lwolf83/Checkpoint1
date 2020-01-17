using System;

namespace CheckPoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tabInt = GetIntegerArrayFromKeyboard();
            Console.WriteLine("Sum of the numbers = " + ArraySum(tabInt));
            Console.WriteLine("Average of the number = " + ArrayAverage(tabInt));

            Console.WriteLine("Before sorting : ");
            DisplayTabOfInteger(tabInt);
            SortArray(tabInt);
            Console.WriteLine("After sorting : ");
            DisplayTabOfInteger(tabInt);
        }

        static int[] GetIntegerArrayFromKeyboard()
        {
            Console.WriteLine("How many number do you want to add?");
            int numberDigit = Convert.ToInt32(Console.ReadLine());

            int[] tabInt = new int[numberDigit];

            for(int i = 0; i < numberDigit; i++)
            {
                Console.Write("Enter number " + (i + 1) + " : ");
                tabInt[i] = Convert.ToInt32(Console.ReadLine());
            }

            return tabInt;
        }

        static int ArraySum(int[] tabInt)
        {
            int sizeTab = tabInt.Length;
            int resultOfSum = 0;

            for(int i = 0; i < sizeTab; i++)
            {
                resultOfSum = resultOfSum + tabInt[i];
            }

            return resultOfSum;
        }

        static double ArrayAverage(int[] tabInt)
        {
            double average;
            int sizeTab = tabInt.Length;

            average = Convert.ToDouble(ArraySum(tabInt)) / sizeTab;

            return average;
        }

        static int[] SortArray(int[] tabInt)
        {
            for(int i = 0; i < tabInt.Length; i++)
            {
                int minPos = GetMinPos(tabInt, i);
                int tempInt = tabInt[i];
                tabInt[i] = tabInt[minPos];
                tabInt[minPos] = tempInt;
            }
            return tabInt;
        }

        static int GetMinPos(int[] tabInt, int firstPosition)
        {
            int min = tabInt[firstPosition];
            int minPos = firstPosition;
            for (int i = firstPosition; i < tabInt.Length; i++)
            {
                if(tabInt[i] < min)
                {
                    min = tabInt[i];
                    minPos = i;
                }
            }

            return minPos;
        }

        static void DisplayTabOfInteger(int[] tabInt)
        {
            for(int i = 0; i < tabInt.Length; i++)
            {
                Console.Write(Convert.ToString(tabInt[i]));
                DisplayPipeBeforeEnd(i, tabInt.Length);
            }
        }

        static void DisplayPipeBeforeEnd(int i, int tabLength)
        {
            if (i < tabLength - 1)
            {
                Console.Write("|");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
