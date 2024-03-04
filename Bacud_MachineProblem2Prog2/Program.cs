namespace Bacud_MachineProblem2Prog2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1 = 0; // 1st Array
            int input2 = 0;

            int input1b = 0; // Second Array
            int input2b = 0;

            int input1c = 0; // Third Array
            int input2c = 0;

            int choice = 0; // Choice


            Random rnd = new Random();
            int placeholder = 0;



            while (true)
            {
                Console.WriteLine("-- MATRIX OPERATIONS --");
                Console.WriteLine();
                Console.Write("Choose an operation: \n[1] Transposition\n[2] Addition\n[3] Subtraction\n[4] Multiplication");
                Console.Write("\n\nInput: ");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1) // TRANSPOSE
                {
                    Console.Clear();
                    Console.WriteLine(" -- Transposition -- ");
                    Console.Write("\n\nInput your desired number of rows: ");

                    input1 = int.Parse(Console.ReadLine());

                    Console.Write("\nInput your desired number of columns: ");

                    input2 = int.Parse(Console.ReadLine());

                    Console.Write("\nGenerating " + input1 + " x " + input2 + " matrix...");
                    Console.WriteLine();

                    int[,] dimensions1 = new int[input1, input2];

                    for (int x = 0; x < dimensions1.GetLength(0); x++) // Generating Numbers in Initial Matrix
                    {
                        for (int y = 0; y < dimensions1.GetLength(1); y++)
                        {
                            dimensions1[x, y] = rnd.Next(1, 11);
                        }
                    }

                    Console.WriteLine();

                    for (int x = 0; x < dimensions1.GetLength(0); x++) // Display Initial Matrix
                    {
                        for (int y = 0; y < dimensions1.GetLength(1); y++)
                        {
                            Console.Write("[" + dimensions1[x, y] + "]" + "\t");
                        }
                        Console.WriteLine();
                    }

                    input1b = input2;           // Second Matrix
                    input2b = input1;

                    int[,] dimensions2 = new int[input1b, input2b];

                    Console.WriteLine("\nGenerating transposed " + input1b + " x " + input2b + " matrix...");

                    for (int x = 0; x < dimensions2.GetLength(0); x++)
                    {
                        for (int y = 0; y < dimensions1.GetLength(0); y++)
                        {
                            dimensions2[x, y] = dimensions1[y, x];
                        }
                    }

                    Console.WriteLine();

                    for (int x = 0; x < dimensions2.GetLength(0); x++) // Display 
                    {
                        for (int y = 0; y < dimensions2.GetLength(1); y++)
                        {
                            Console.Write("[" + dimensions2[x, y] + "]" + "\t");
                        }
                        Console.WriteLine();
                    }


                    break;
                }

                else if (choice == 2) // ADDITION 
                {
                    Console.Clear();
                    Console.WriteLine(" -- ADDITION -- ");
                    Console.Write("\nInput your desired number of rows: ");

                    input1 = int.Parse(Console.ReadLine());

                    Console.Write("\nInput your desired number of columns: ");

                    input2 = int.Parse(Console.ReadLine());

                    Console.Write("\nGenerating 1st " + input1 + " x " + input2 + " matrix...");
                    Console.WriteLine();

                    int[,] dimensions1 = new int[input1, input2];

                    for (int x = 0; x < dimensions1.GetLength(0); x++) // Generating Numbers in Matrix
                    {
                        for (int y = 0; y < dimensions1.GetLength(1); y++)
                        {
                            dimensions1[x, y] = rnd.Next(1, 11);
                        }
                    }

                    Console.WriteLine();

                    for (int x = 0; x < dimensions1.GetLength(0); x++) // Display 
                    {
                        for (int y = 0; y < dimensions1.GetLength(1); y++)
                        {
                            Console.Write("[" + dimensions1[x, y] + "]" + "\t");
                        }
                        Console.WriteLine();
                    }


                    input1b = input1; // SECOND ARRAY
                    input2b = input2;

                    int[,] dimensions2 = new int[input1b, input2b];

                    Console.WriteLine("\nGenerating 2nd " + input1b + " x " + input2b + " matrix...");

                    for (int x = 0; x < dimensions2.GetLength(0); x++) // Generating Numbers in Matrix
                    {
                        for (int y = 0; y < dimensions2.GetLength(1); y++)
                        {
                            dimensions2[x, y] = rnd.Next(1, 11);
                        }
                    }

                    Console.WriteLine();

                    for (int x = 0; x < dimensions2.GetLength(0); x++) // Display 
                    {
                        for (int y = 0; y < dimensions2.GetLength(1); y++)
                        {
                            Console.Write("[" + dimensions2[x, y] + "]" + "\t");
                        }
                        Console.WriteLine();
                    }

                    input1c = input1;
                    input2c = input2;

                    Console.WriteLine("\nAdding Matrices...");

                    int[,] dimensions3 = new int[input1c, input2c]; // THIRD ARRAY

                    for (int x = 0; x < dimensions3.GetLength(0); x++) // Display 
                    {
                        for (int y = 0; y < dimensions3.GetLength(1); y++)
                        {
                            dimensions3[x, y] = dimensions1[x, y] + dimensions2[x, y];
                        }
                    }

                    Console.WriteLine("\nFinal Sum of the Matrices:\n ");

                    for (int x = 0; x < dimensions2.GetLength(0); x++) // Display 
                    {
                        for (int y = 0; y < dimensions2.GetLength(1); y++)
                        {
                            Console.Write("[" + dimensions3[x, y] + "]" + "\t");
                        }
                        Console.WriteLine();
                    }

                    break;
                }

                else if (choice == 3) // SUBTRACTION
                {
                    Console.Clear();
                    Console.WriteLine(" -- SUBTRACTION -- ");
                    Console.Write("\nInput your desired number of rows: ");

                    input1 = int.Parse(Console.ReadLine());

                    Console.Write("\nInput your desired number of columns: ");

                    input2 = int.Parse(Console.ReadLine());

                    Console.Write("\nGenerating 1st " + input1 + " x " + input2 + " matrix...");
                    Console.WriteLine();

                    int[,] dimensions1 = new int[input1, input2];

                    for (int x = 0; x < dimensions1.GetLength(0); x++) // Generating Numbers in Matrix
                    {
                        for (int y = 0; y < dimensions1.GetLength(1); y++)
                        {
                            dimensions1[x, y] = rnd.Next(1, 11);
                        }
                    }

                    Console.WriteLine();

                    for (int x = 0; x < dimensions1.GetLength(0); x++) // Display 
                    {
                        for (int y = 0; y < dimensions1.GetLength(1); y++)
                        {
                            Console.Write("[" + dimensions1[x, y] + "]" + "\t");
                        }
                        Console.WriteLine();
                    }


                    input1b = input1; // SECOND ARRAY
                    input2b = input2;

                    int[,] dimensions2 = new int[input1b, input2b];

                    Console.WriteLine("\nGenerating 2nd " + input1b + " x " + input2b + " matrix...");

                    for (int x = 0; x < dimensions2.GetLength(0); x++) // Generating Numbers in Matrix
                    {
                        for (int y = 0; y < dimensions2.GetLength(1); y++)
                        {
                            dimensions2[x, y] = rnd.Next(1, 11);
                        }
                    }

                    Console.WriteLine();

                    for (int x = 0; x < dimensions2.GetLength(0); x++) // Display 
                    {
                        for (int y = 0; y < dimensions2.GetLength(1); y++)
                        {
                            Console.Write("[" + dimensions2[x, y] + "]" + "\t");
                        }
                        Console.WriteLine();
                    }

                    input1c = input1;
                    input2c = input2;

                    Console.WriteLine("\nAdding Matrices...");

                    int[,] dimensions3 = new int[input1c, input2c]; // THIRD ARRAY

                    for (int x = 0; x < dimensions3.GetLength(0); x++) // Display 
                    {
                        for (int y = 0; y < dimensions3.GetLength(1); y++)
                        {
                            dimensions3[x, y] = dimensions1[x, y] - dimensions2[x, y];
                        }
                    }

                    Console.WriteLine("\nFinal Sum of the Matrices:\n ");

                    for (int x = 0; x < dimensions2.GetLength(0); x++) // Display 
                    {
                        for (int y = 0; y < dimensions2.GetLength(1); y++)
                        {
                            Console.Write("[" + dimensions3[x, y] + "]" + "\t");
                        }
                        Console.WriteLine();
                    }

                    break;
                }

                else if (choice == 4) // MULTIPLICATION
                {
                    Console.Clear();

                    while (true)
                    {
                        Console.WriteLine("-- MULTIPLICATION --");
                        Console.Write("\nFirst Matrix: ");
                        Console.Write("\nInput your desired number of rows: ");

                        input1 = int.Parse(Console.ReadLine());

                        Console.Write("\nInput your desired number of columns: ");

                        input2 = int.Parse(Console.ReadLine());

                        Console.Write("\nGenerating 1st " + input1 + " x " + input2 + " matrix...");
                        Console.WriteLine();

                        int[,] dimensions1 = new int[input1, input2];

                        for (int x = 0; x < dimensions1.GetLength(0); x++) // Generating Numbers in Matrix
                        {
                            for (int y = 0; y < dimensions1.GetLength(1); y++)
                            {
                                dimensions1[x, y] = rnd.Next(1, 11);
                            }
                        }

                        Console.WriteLine();

                        for (int x = 0; x < dimensions1.GetLength(0); x++) // Display 
                        {
                            for (int y = 0; y < dimensions1.GetLength(1); y++)
                            {
                                Console.Write("[" + dimensions1[x, y] + "]"+ "\t");
                            }
                            Console.WriteLine();
                        }

                        Console.Write("\nSecond Matrix: ");
                        Console.Write("\n\nNOTE: THE NUMBER ROWS FOR THE SECOND MATRIX SHOULD BE EQUAL TO THE NUMBER COLUMNS OF THE FIRST MATRIX.\nTHE SAME GOES AS WELL FOR THE NUMBER OF COLUMNS FOR THE SECOND MATRIX AND THE NUMBER OF ROWS OF THE FIRST MATRIX");
                        Console.Write("\n\nInput your desired number of rows: ");

                        input1b = int.Parse(Console.ReadLine());

                        Console.Write("\nInput your desired number of columns: ");

                        input2b = int.Parse(Console.ReadLine());

                        int[,] dimensions2 = new int[input1b, input2b];

                        for (int x = 0; x < dimensions2.GetLength(0); x++) // Generating Numbers in Matrix
                        {
                            for (int y = 0; y < dimensions2.GetLength(1); y++)
                            {
                                dimensions2[x, y] = rnd.Next(1, 11);
                            }
                        }

                        if (input1b == input2 && input2b == input1)
                        {
                            Console.WriteLine("\nGenerating 2nd " + input1b + " x " + input2b+ " matrix...");
                            Console.WriteLine();

                            for (int x = 0; x < dimensions2.GetLength(0); x++) // Display 
                            {
                                for (int y = 0; y < dimensions2.GetLength(1); y++)
                                {
                                    Console.Write("[" + dimensions2[x, y] + "]" + "\t");
                                }
                                Console.WriteLine();
                            }

                            Console.Write("\nMultiplying Matrices... ");

                            input1c = input1b;
                            input2c = input2b;
                               
                            int[,] dimensions3 = new int[input1c, input2c]; // THIRD ARRAY

                            for (int x = 0; x < dimensions3.GetLength(0); x++)
                            {
                                for (int y = 0; y < dimensions2.GetLength(0); y++)
                                {
                                    for (int z = 0; z < dimensions1.GetLength(0); y++)
                                    {
                                        dimensions3[x, y] = dimensions1[z, y] + dimensions2[y, z]; 
                                    }
                                }
                            }

                            for (int x = 0; x < dimensions1.GetLength(0); x++) // Display 
                            {
                                for (int y = 0; y < dimensions1.GetLength(1); y++)
                                {
                                    Console.Write(dimensions3[x, y] + "\t");
                                }
                                Console.WriteLine();
                            }

                            break;
                        }
                            
                        else
                        {
                            Console.WriteLine("\n** ERROR: The inputs are not valid. Please try again. **");
                            Console.ReadKey();
                            Console.Clear();
                        }
                            
                               
                        }
                        break;
                    }
                    Console.WriteLine("\n** ERROR: The input does not exist. Please try again. **");
                    Console.ReadKey();
                    Console.Clear();
                }



            }
        }
    }

    