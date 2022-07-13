using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };
            var numbers = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(numbers);

            //Random random = new Random();
            //int value = random.Next(0, array.Length);
            //Console.Write(array[value]);

            //TODO: Print the first number of the array
            Console.WriteLine(numbers[0]);


            //TODO: Print the last number of the array            
            Console.WriteLine($"{numbers[numbers.Length - 1]}");
            //Console.WriteLine(last);


            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(numbers);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            //ThreeKiller(array);
            

                //Console.WriteLine(PrintNumbers);

                //TODO: Sort the array in order now
                /*      Hint: Array.____()      */
                Console.WriteLine("Sorted numbers:");
                Array.Sort(numbers);
                NumberPrinter(numbers);

                Console.WriteLine("\n************End Arrays*************** \n");
                #endregion

                #region Lists
                Console.WriteLine("************Start Lists**************");

                /*   Set Up   */
                //TODO: Create an integer List
                var numList = new List<int>();

                //TODO: Print the capacity of the list to the console
                Console.WriteLine(numList.Count);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(numList);

            //TODO: Print the new capacity
            Console.WriteLine( numList.Capacity);

                Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!

            int userNumber;
            bool isANumber;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isANumber = int.TryParse(Console.ReadLine(), out userNumber);

            } while (isANumber == false);



            NumberChecker(numList, userNumber);

                //Console.WriteLine("-------------------");

                Console.WriteLine("All Numbers:");
                //UNCOMMENT this method to print out your numbers from arrays or lists
                NumberPrinter(numList);
                Console.WriteLine("-------------------");


                //TODO: Create a method that will remove all odd numbers from the list then print results
                Console.WriteLine("Evens Only!!");
            OddKiller(numList);
                Console.WriteLine("------------------");

                //TODO: Sort the list then print results
                Console.WriteLine("Sorted Evens!!");
            numList.Sort();
            NumberPrinter(numList);
                Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var myArray = numList.ToArray;

            //TODO: Clear the list
            numList.Clear();

                #endregion
            
        }
    



private static void ThreeKiller(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 3 == 0)
        {
            numbers[i] = 0;
        }
    }
}

private static void OddKiller(List<int> numberList)
{
    for (int i = 0; i < numberList.Count; i++)
    {
        if (numberList[i] % 2 != 0)
            {
                    numberList.Remove(numberList[i]);
            }
      }
 }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                if (searchNumber == numberList[i])
                {
                    Console.WriteLine("you have a match");
                }
            }
        }

private static void Populater(List<int> numberList)

{
    Random rng = new Random();
    for (int i = 0; i < 51; i++)
    {
        numberList.Add(Random.Next(0, 50));
    }

}

private static void Populater(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)

    {
        Random rng = new Random();
        numbers[i] = rng.Next(0, 51);

    }


}

private static void ReverseArray(int[] array)
{
    Array.Reverse(array);
    NumberPrinter(array);

}

//        /// <summary>
//        /// Generic print method will iterate over any collection that implements IEnumerable<T>
//        /// </summary>
//        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
//        /// <param name="collection"></param>
private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
{
    //STAY OUT DO NOT MODIFY!!
    foreach (var item in collection)
    {
        Console.WriteLine(item);
    }
}
    }
}

    }
}
