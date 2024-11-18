using System.Security.Cryptography;

namespace Solve_Task_2_13_11_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in my apllecation");
            List<int> nums = new List<int>();

            char option = ' ';
            do
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("P - Print numbers ");
                Console.WriteLine("A - Add a number ");
                Console.WriteLine("M - Display mean of the numbers ");
                Console.WriteLine("S - Display the smallest number ");
                Console.WriteLine("L - Display the largest number ");
                Console.WriteLine("Q - Quit ");
                Console.Write("Please Choose option do you need: ");
                option = char.ToUpper(char.Parse(Console.ReadLine()));


                // print numbers
                if (option == 'P')
                {
                    if (nums.Count == 0)
                        Console.WriteLine("[] - The list is empty");
                    else
                    {
                        Console.Write("[");
                        for (int i = 0; i < nums.Count; ++i)
                        {
                            Console.Write(nums[i]);
                        }
                        Console.WriteLine("]");
                    }
                }




                // ------- Why  in option add this code make error ---------
                //else if (option == 'A')
                //{ 
            //     int numAdded = 0;
            //    for (int i = 0; i < nums.Count; ++i)
            //    {
            //        nums.Add(int.Parse(Console.ReadLine()));
            //    }

            //    Console.WriteLine($"{numAdded} added.");
            //}
            // else
            //{
            //    Console.WriteLine("Please enter a valid number.");
            //}
                //}
        


                //Add number
                else if (option == 'A')
                {
                    Console.Write("Enter the number to add: ");
                    if (int.TryParse(Console.ReadLine(), out int numAdded))
                    {
                        nums.Add(numAdded);
                        Console.WriteLine($"{numAdded} added.");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }


                //Avrrage
                else if (option == 'M')
                {
                    if (nums.Count == 0)
                    {
                        Console.WriteLine("Unable to calculate the mean because the list is empty");
                    }
                    else
                    {
                        int sum = 0;
                        for (int i = 0; i < nums.Count; ++i)
                        {
                            sum += nums[i];
                        }
                        double avrrage = (double)sum / nums.Count;
                        Console.WriteLine($"The mean is: {avrrage}");
                    }
                }

                //Smallest
                else if (option == 'S')
                {
                    if (nums.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the smallest number because the list is empty");
                    }
                    else
                    {
                        int smallest = nums[0];
                        for (int i = 0; i < nums.Count; ++i)
                        {
                            if (nums[i] < smallest)
                            {
                                smallest = nums[i];
                            }
                        }
                        Console.WriteLine($"The Smallest number is: {smallest}");
                    }
                }

                //Largest
                else if (option == 'L')
                {
                    if (nums.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the largest number because the list is empty");
                    }
                    else
                    {
                        int largest = nums[0];
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] > largest)
                            {
                                largest = nums[i];
                            }
                        }
                        Console.WriteLine($"The largest numder is: {largest}");
                    }
                }

                //Exit
                else if (option == 'Q')
                {
                    Console.WriteLine("Good bye");
                }

            }
            while (option != 'Q');


        }
    }
}