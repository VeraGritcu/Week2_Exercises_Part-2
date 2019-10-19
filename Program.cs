using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Exercises_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Sum the values of an array and display it to console.
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            //int sumaTotala = SumaTotalaArray(array);
            //Console.WriteLine(sumaTotala);

            //2.Calculate the average value of array elements.
            //CalculateAverageValue(array);

            //3.Find the index of an element in an array.
            //PrintIndex(array, 2);

            //4.Remove a specific element from an array.
            //RemoveElementFromArray(array, 3);

            //5.Insert an element into an array at a specified position.
            //InsertNewElementInArray(array, 6, 2);

            //6.Find the maximum and minimum value of an array.
            //FindMinAndMax(array);

            //7.Find common elements between two arrays of integers.

            int[] array2 = new int[] { 4, 5, 6, 7, 8 };
            //FindCommonElements(array, array2);


            //8.Copy elements from an array into another
            int[] newArray = new int[array.Length];
            for (int i = 0,j=0; i < array.Length; i++,j++)
            {
                newArray[j] = array[i];
                Console.Write(newArray[j]);
            }

        }

        private static void FindCommonElements(int[] array, int[] array2)
        {
            int[] commonElements = new int[array.Length];
            bool commonIndicator = false;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0, k = 0; j < array2.Length; j++, k++)
                {
                    if (array[i] == array2[j] && commonIndicator == ElementPresence(commonElements, array[i]))
                    {
                        commonElements[k] = array[i];
                        continue;
                    }
                }
            }
            Console.Write("Common elements between the 2 arrays are: ");
            foreach (var item in commonElements)
            {
                if (item != 0)
                {
                    Console.Write($"{item}, ");
                }

            }
        }
        private static bool ElementPresence(int[] array, int x)
    {
        bool existent = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == x)
            {
                existent = true;
                break;
            }
        }
    
        return existent;
    }

    private static void FindMinAndMax(int[] array)
        {
            bool noChangeswitch = true;
            do
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    int intermediateNumber = 0;
                    if (array[i] > array[i + 1])
                    {
                        intermediateNumber = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = intermediateNumber;
                        noChangeswitch = false;
                    }
                }

            }
            while (noChangeswitch == false);

            Console.Write($"Maximum element from array is {array[array.Length - 1]} while minimum is {array[0]}");
        }

        private static void InsertNewElementInArray(int[] array, int newElement, int indexOfNewElement)
        {
            int[] newArray = new int[array.Length + 1];
            Console.Write("Your new array looks now like this: ");
            for (int a = 0, na = 0; na < newArray.Length; a++, na++)
            {
                if (na != indexOfNewElement)
                {
                    newArray[na] = array[a];
                    Console.Write($"{newArray[na]}, ");

                }

                else
                {
                    newArray[na] = newElement;
                    Console.Write($"{newArray[na]}, ");
                    a = a - 1;
                }

            }
        }

        private static void RemoveElementFromArray(int[] array, int referenceValue)
        {
            int[] newArray = new int[array.Length - 1];
            Console.Write("Your new array looks now like this: ");
            for (int a = 0, na = 0; a < array.Length; a++, na++)
            {
                if (array[a] != referenceValue)
                {
                    newArray[na] = array[a];
                    Console.Write($"{array[a]}, ");

                }
                else
                {
                    na = na - 1;
                }

            }
        }

        private static void PrintIndex(int[] array, int referenceValue)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == referenceValue)
                {
                    Console.WriteLine($"Index of the {referenceValue} in the current array is {i}");
                    continue;
                }

            }
        }

        private static void CalculateAverageValue(int[] array)
        {
            int averageValue = SumaTotalaArray(array) / array.Length;
            Console.WriteLine(averageValue);
        }

        private static int SumaTotalaArray(int[] array)
        {
            int suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                suma = suma + array[i];

            }
            return suma;
        }
    }
}
