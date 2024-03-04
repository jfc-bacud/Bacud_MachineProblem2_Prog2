using System.ComponentModel.Design;

namespace Bacud_MachineProblem2Prog2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1 = 0; // Indexes for the First Array
            int input2 = 0;

            int input1b = 0; // Indexes for the Second Array
            int input2b = 0;

            int input1c = 0; // Indexes for the Third Array
            int input2c = 0;

            int choice = 0; // Main Menu Choice

            int choice2 = 0; // Retry Again Choice

            Random rnd = new Random(); // Random Number Generator

            while (true)
            {
                // MAIN MENU 

                Console.Clear();
                Console.WriteLine("-- MATRIX OPERATIONS --");
                Console.WriteLine();
                Console.Write("Choose an operation: \n[1] Transposition\n[2] Addition\n[3] Subtraction\n[4] Multiplication");
                Console.Write("\n\nInput: ");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1) // TRANSPOSITION OPERATION
                {
                    Console.Clear();

                    while (true)
                    {
                        Console.WriteLine(" -- TRANSPOSITION -- ");
                        Console.Write("\nInput your desired number of rows: ");

                        input1 = int.Parse(Console.ReadLine()); // INPUT FOR ROWS

                        Console.Write("\nInput your desired number of columns: ");

                        input2 = int.Parse(Console.ReadLine()); // INPUT FOR COLUMNS

                        Console.Write("\nGenerating " + input1 + " x " + input2 + " matrix...");
                        Console.WriteLine();

                        int[,] dimensions1 = new int[input1, input2];

                        // GENERATING NUMBERS IN INDEXES OF FIRST MATRIX

                        for (int x = 0; x < dimensions1.GetLength(0); x++) 
                        {
                            for (int y = 0; y < dimensions1.GetLength(1); y++)
                            {
                                dimensions1[x, y] = rnd.Next(1, 11);
                            }
                        }

                        Console.WriteLine();

                        // DISPLAY NUMBERS STORED IN INDEXES OF FIRST MATRIX

                        for (int x = 0; x < dimensions1.GetLength(0); x++) 
                        {
                            for (int y = 0; y < dimensions1.GetLength(1); y++)
                            {
                                Console.Write("[" + dimensions1[x, y] + "]" + "\t");
                            }
                            Console.WriteLine();
                        }

                        // DECLARATION OF SECOND MATRIX

                        input1b = input2;           
                        input2b = input1;       

                        int[,] dimensions2 = new int[input1b, input2b];

                        Console.WriteLine("\nGenerating transposed " + input1b + " x " + input2b + " matrix...");

                        // TRANSPOSING ALGORITHM

                        for (int x = 0; x < dimensions2.GetLength(0); x++)
                        {
                            for (int y = 0; y < dimensions1.GetLength(0); y++)
                            {
                                dimensions2[x, y] = dimensions1[y, x];
                            }
                        }

                        Console.WriteLine();

                        // DISPLAYS FINAL AND TRANSPOSED MATRIX 

                        for (int x = 0; x < dimensions2.GetLength(0); x++) 
                        {
                            for (int y = 0; y < dimensions2.GetLength(1); y++)
                            {
                                Console.Write("[" + dimensions2[x, y] + "]" + "\t");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine("\nProcess is done. Press Any Key to Continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }

                }

                else if (choice == 2) // ADDITION OPERATION
                {
                    Console.Clear();

                    while (true)
                    {
                        Console.WriteLine(" -- ADDITION -- ");
                        Console.Write("\nInput your desired number of rows: "); 

                        input1 = int.Parse(Console.ReadLine()); // INPUT FOR ROWS

                        Console.Write("\nInput your desired number of columns: "); 

                        input2 = int.Parse(Console.ReadLine()); // INPUT FOR COLUMNS

                        Console.Write("\nGenerating 1st " + input1 + " x " + input2 + " matrix...");
                        Console.WriteLine();

                        int[,] dimensions1 = new int[input1, input2];

                        // GENERATING NUMBERS IN FIRST MATRIX

                        for (int x = 0; x < dimensions1.GetLength(0); x++) 
                        {
                            for (int y = 0; y < dimensions1.GetLength(1); y++)
                            {
                                dimensions1[x, y] = rnd.Next(1, 11);
                            }
                        }

                        Console.WriteLine();

                        // DISPLAYS FIRST MATRIX

                        for (int x = 0; x < dimensions1.GetLength(0); x++) 
                        {
                            for (int y = 0; y < dimensions1.GetLength(1); y++)
                            {
                                Console.Write("[" + dimensions1[x, y] + "]" + "\t");
                            }
                            Console.WriteLine();
                        }

                        // DECLARATION OF SECOND MATRIX

                        input1b = input1; 
                        input2b = input2;

                        int[,] dimensions2 = new int[input1b, input2b];

                        Console.WriteLine("\nGenerating 2nd " + input1b + " x " + input2b + " matrix...");

                        // GENERATING NUMBERS IN SECOND MATRIX

                        for (int x = 0; x < dimensions2.GetLength(0); x++) 
                        {
                            for (int y = 0; y < dimensions2.GetLength(1); y++)
                            {
                                dimensions2[x, y] = rnd.Next(1, 11);
                            }
                        }

                        Console.WriteLine();

                        // DISPLAY SECOND MATRIX

                        for (int x = 0; x < dimensions2.GetLength(0); x++)
                        {
                            for (int y = 0; y < dimensions2.GetLength(1); y++)
                            {
                                Console.Write("[" + dimensions2[x, y] + "]" + "\t");
                            }
                            Console.WriteLine();
                        }


                        // DECLARATION OF THIRD ARRAY -> FINAL (RESULT) ARRAY

                        input1c = input1;
                        input2c = input2; 

                        Console.WriteLine("\nAdding Matrices...");

                        int[,] dimensions3 = new int[input1c, input2c]; 

                        // ADDITION OPERATION BETWEEN SEVERAL ARRAYS

                        for (int x = 0; x < dimensions3.GetLength(0); x++) 
                        {
                            for (int y = 0; y < dimensions3.GetLength(1); y++)
                            {
                                dimensions3[x, y] = dimensions1[x, y] + dimensions2[x, y];
                            }
                        }

                        // DISPLAYS FINAL RESULT

                        Console.WriteLine("\nFinal Sum of the Matrices:\n ");

                        for (int x = 0; x < dimensions2.GetLength(0); x++) // Display 
                        {
                            for (int y = 0; y < dimensions2.GetLength(1); y++)
                            {
                                Console.Write("[" + dimensions3[x, y] + "]" + "\t");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine("\nProcess is done. Press Any Key to Continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    }
                    
                }

                else if (choice == 3) // SUBTRACTION OPERATION
                {
                    Console.Clear();

                    while (true)
                    {
                        Console.WriteLine(" -- SUBTRACTION -- ");
                        Console.Write("\nInput your desired number of rows: ");

                        input1 = int.Parse(Console.ReadLine()); // INPUT ROWS

                        Console.Write("\nInput your desired number of columns: ");

                        input2 = int.Parse(Console.ReadLine()); // INPUT COLUMNS

                        Console.Write("\nGenerating 1st " + input1 + " x " + input2 + " matrix...");
                        Console.WriteLine();

                        int[,] dimensions1 = new int[input1, input2];

                        // GENERATING NUMBERS IN FIRST MATRIX

                        for (int x = 0; x < dimensions1.GetLength(0); x++) 
                        {
                            for (int y = 0; y < dimensions1.GetLength(1); y++)
                            {
                                dimensions1[x, y] = rnd.Next(1, 11);
                            }
                        }

                        Console.WriteLine();

                        // DISPLAYS FIRST MATRIX

                        for (int x = 0; x < dimensions1.GetLength(0); x++) 
                        {
                            for (int y = 0; y < dimensions1.GetLength(1); y++)
                            {
                                Console.Write("[" + dimensions1[x, y] + "]" + "\t");
                            }
                            Console.WriteLine();
                        }

                        // DECLARATION OF SECOND ARRAY / MATRIX

                        input1b = input1; 
                        input2b = input2;

                        int[,] dimensions2 = new int[input1b, input2b];

                        Console.WriteLine("\nGenerating 2nd " + input1b + " x " + input2b + " matrix...");

                        // GENERATING NUMBERS IN SECOND MATRIX

                        for (int x = 0; x < dimensions2.GetLength(0); x++) 
                        {
                            for (int y = 0; y < dimensions2.GetLength(1); y++)
                            {
                                dimensions2[x, y] = rnd.Next(1, 11);
                            }
                        }

                        Console.WriteLine();

                        // DISPLAYS SECOND MATRIX

                        for (int x = 0; x < dimensions2.GetLength(0); x++) 
                        {
                            for (int y = 0; y < dimensions2.GetLength(1); y++)
                            {
                                Console.Write("[" + dimensions2[x, y] + "]" + "\t");
                            }
                            Console.WriteLine();
                        }

                        // DECLARATION OF FINAL ARRAY (RESULT)

                        input1c = input1;
                        input2c = input2;

                        Console.WriteLine("\nSubtracting Matrices...");

                        int[,] dimensions3 = new int[input1c, input2c]; 

                        // SUBTRACTION ALGORITHM

                        for (int x = 0; x < dimensions3.GetLength(0); x++) 
                        {
                            for (int y = 0; y < dimensions3.GetLength(1); y++)
                            {
                                dimensions3[x, y] = dimensions1[x, y] - dimensions2[x, y];
                            }
                        }

                        // DISPLAYS RESULT

                        Console.WriteLine("\nFinal Difference of the Matrices:\n ");

                        for (int x = 0; x < dimensions2.GetLength(0); x++) // Display 
                        {
                            for (int y = 0; y < dimensions2.GetLength(1); y++)
                            {
                                Console.Write("[" + dimensions3[x, y] + "]" + "\t");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine("\nProcess is done. Press Any Key to Continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                  
                }

                else if (choice == 4) // MULTIPLICATION OPERATION
                {
                    Console.Clear();

                    while (true)
                    {
                        Console.WriteLine("-- MULTIPLICATION --");
                        Console.Write("\nFirst Matrix: ");
                        Console.Write("\n\nInput your desired number of rows: ");

                        input1 = int.Parse(Console.ReadLine()); // INPUT ROWS

                        Console.Write("\nInput your desired number of columns: ");

                        input2 = int.Parse(Console.ReadLine()); // INPUT COLUMNS

                        Console.Write("\nGenerating 1st " + input1 + " x " + input2 + " matrix...");
                        Console.WriteLine();

                        int[,] dimensions1 = new int[input1, input2];

                        // GENERATING NUMBERS IN THE FIRST MATRIX

                        for (int x = 0; x < dimensions1.GetLength(0); x++) 
                        {
                            for (int y = 0; y < dimensions1.GetLength(1); y++)
                            {
                                dimensions1[x, y] = rnd.Next(1, 11);
                            }
                        }

                        Console.WriteLine();

                        // DISPLAYS FIRST MATRIX

                        for (int x = 0; x < dimensions1.GetLength(0); x++) 
                        {
                            for (int y = 0; y < dimensions1.GetLength(1); y++)
                            {
                                Console.Write("[" + dimensions1[x, y] + "]" + "\t");
                            }
                            Console.WriteLine();
                        }

                        // SECOND MATRIX INPUTS WITH NOTE

                        Console.Write("\n\nSecond Matrix: ");
                        Console.Write("\n\n** NOTE: THE NUMBER ROWS AND COLUMNS OF THE SECOND MATRIX SHOULD BE EQUAL\nTO THE VALUE OF THE COLUMNS AND ROWS OF THE FIRST MATRIX RESPECTIVELY **");
                        Console.Write("\n\nInput your desired number of rows: ");

                        input1b = int.Parse(Console.ReadLine());

                        Console.Write("\nInput your desired number of columns: ");

                        input2b = int.Parse(Console.ReadLine());

                        int[,] dimensions2 = new int[input1b, input2b];

                        // GENERATING NUMBERS IN THE MATRIX

                        for (int x = 0; x < dimensions2.GetLength(0); x++) 
                        {
                            for (int y = 0; y < dimensions2.GetLength(1); y++)
                            {
                                dimensions2[x, y] = rnd.Next(1, 11);
                            }
                        }

                        // CHECKING IF CONDITIONS FROM NOTE ARE FULLFILLED

                        if (input1b == input2 && input2b == input1)
                        {
                            Console.WriteLine("\nGenerating 2nd " + input1b + " x " + input2b + " matrix...");
                            Console.WriteLine();

                            // DISPLAY OF SECOND MATRIX

                            for (int x = 0; x < dimensions2.GetLength(0); x++) 
                            {
                                for (int y = 0; y < dimensions2.GetLength(1); y++)
                                {
                                    Console.Write("[" + dimensions2[x, y] + "]" + "\t");
                                }
                                Console.WriteLine();
                            }

                            Console.Write("\nMultiplying Matrices... ");

                            // DECLARATION OF FINAL RESULT MATRIX

                            input1c = input1;
                            input2c = input2b;

                            int[,] dimensions3 = new int[input1c, input2c]; 

                            // MULTIPLICATION ALGORITHM 

                            for (int x = 0; x < dimensions3.GetLength(0); x++) 
                            {
                                for (int y = 0; y < dimensions3.GetLength(1); y++)
                                {
                                    for (int z = 0; z < dimensions1.GetLength(1); z++)
                                    {
                                        dimensions3[x, y] += (dimensions2[z, y] * dimensions1[x, z]);
                                    }
                                }
                            }

                            Console.WriteLine();

                            Console.WriteLine("\nFinal Product of the Matrices: \n");

                            // DISPLAYS RESULT

                            for (int x = 0; x < dimensions3.GetLength(0); x++) 
                            {
                                for (int y = 0; y < dimensions3.GetLength(1); y++)
                                {
                                    Console.Write("[" + dimensions3[x, y] + "]" + "\t");
                                }
                                Console.WriteLine();
                            }

                            Console.WriteLine("\nProcess is done. Press Any Key to Continue.");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        }

                        else
                        {

                            // ERROR IN CASE USER DOES NOT COMPLY WITH CONDITIONS -> RESETS PROMPT

                            Console.WriteLine("\n** ERROR: The inputs are not valid. Please try again and follow instructions. **"); 
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }

                else
                {
                    // ERROR MESSAGE IF INPUT DOES NOT EXIST IN MAIN MENU

                    Console.WriteLine("\n** ERROR: The input does not exist. Please try again. **");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                while (true) // INQUIRY MESSAGE IF USER WANTS TO TRY AGAIN
                {
                    Console.Clear();
                    Console.WriteLine("\nDo you wish to do another operation?");
                    Console.Write("[1] Yes\n[2] No");

                    Console.Write("\n\nInput: ");

                    choice2 = int.Parse(Console.ReadLine());

                    if (choice2 == 1)
                    {
                        break;
                    }
                   

                    else if (choice2 == 2)
                    {
                        break;
                    }

                    else
                    {
                        // ERROR MESSAGE IF INPUT DOES NOT EXIST FROM RETRY SCREEN -> RESETS PROMPT
                        Console.WriteLine("\n** ERROR: The input does not exist. Please try again. **");
                        Console.ReadKey();
                        Console.Clear();
                    }

                }

                if (choice2 == 1) 
                {
                    //CONTINUES LOOP, GOES BACK TO VERY START

                    continue; 
                }

                break;

            }

            // POST-PROGRAM MESSAGE

            Console.Clear();
            Console.WriteLine("Press any key to end the program");  
            Console.ReadKey();
            Console.Clear();

        }
    }
}

    