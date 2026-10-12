namespace Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
               // 1- Write a program that takes a number from the user then print yes if
                // that number can be divided by 3 and 4 otherwise print no.
                //   int number = int.Parse(Console.ReadLine());
                //  if (number % 3 == 0 && number % 4 == 0)
                // {
                //   Console.WriteLine("yes");
                //  }
                //   else
                //   {
                //     Console.WriteLine("no");
                //  }

                //2-  Write a program that allows the user to insert an integer then print
                // negative if it is negative number otherwise print positive.
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine(num < 0 ? "negative" : "positive");   // ternary operator

                // 3- Write a program that takes 3 integers from the user then prints the max
                // element and the min element.
                //int num1 = int.Parse(Console.ReadLine());
                //int num2 = int.Parse(Console.ReadLine());
                //int num3 = int.Parse(Console.ReadLine());

                //int max = Math.Max(num1, Math.Max(num2, num3));
                //int min = Math.Min(num1, Math.Min(num2, num3));
                //Console.WriteLine($"Max: {max}, Min: {min}");

                // 4- Write a program that allows the user to insert an integer number then
                // check If a number is even or odd.
                //int checkNum = int.Parse(Console.ReadLine());
                //string result = (checkNum % 2 == 0) ? "even" : "odd";
                //Console.WriteLine(result);
                //5- Write a program that takes character from the user then if it is a
                //  vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
                //char ch = char.ToLower(char.Parse(Console.ReadLine()));
                // string input  = Console.ReadLine();
                //  char ch = char.ToLower(input[0]);
                //switch (ch)
                //{
                //    case 'a':
                //    case 'e':
                //    case 'i':
                //    case 'o':
                //    case 'u':
                //        Console.WriteLine("vowel");
                //        break;
                //    default:
                //        Console.WriteLine("consonant");
                //        break;
                //}


                //6- Write a program that allows the user to insert an integer then print
                // all numbers between 1 to that number.
                //int inputNum = int.Parse(Console.ReadLine());
                //for (int i = 1; i <= inputNum; ++i)
                //{
                //    Console.WriteLine(i);
                //}
                //7- Write a program that allows the user to insert an integer then
                //   print a multiplication table up to 12.

                //int tableNum = int.Parse(Console.ReadLine());
                //if (tableNum != 0)
                //{
                //    for (int i = 1; i <= 12; ++i)
                //    {
                //        Console.WriteLine($"{tableNum} x {i} = {tableNum * i}");
                //    }
                //    Console.WriteLine($"multiplication any thing by Zero = zero ");
                //}

                // 8- Write a program that allows to user to insert number then print all
                // even numbers between 1 to this number
                //int Num = int.Parse(Console.ReadLine());
                //for (int i = 1; i <= Num; ++i)
                //{
                //    if (i % 2 == 0)
                //    {
                //        Console.WriteLine(i);
                //    }

                //}

                // 9- Write a program that takes two integers then prints the power.
                //int baseNum = int.Parse(Console.ReadLine());
                //int exponent = int.Parse(Console.ReadLine());
                //double result1 = Math.Pow(baseNum, exponent);

                // 10- Write a program to enter marks of five subjects and calculate total,
                //average and percentage.
                //int[] subjects = new int[5];
                //double total = 0;

                //for (int i = 0; i < 5; ++i)
                //{
                //    subjects[i] = int.Parse(Console.ReadLine());
                //}
                //for (int i = 0; i < 5; ++i)
                //{
                //    total += subjects[i];

                //}
                //Console.WriteLine($"Average : {total / subjects.Length}");

                // 11- Write a program to input the month number and print the number of days
                //in that month.
                //int month = int.Parse(Console.ReadLine());
                //switch (month)
                //{
                //    case 1:
                //    case 3:
                //    case 5:
                //    case 7:
                //    case 8:
                //    case 10:
                //    case 12:
                //        Console.WriteLine("31 days");
                //        break;
                //    case 4:
                //    case 6:
                //    case 9:
                //    case 11:
                //        Console.WriteLine("30 days");
                //        break;
                //    case 2:
                //        Console.WriteLine("28 or 29 days");
                //        break;
                //    default:
                //        Console.WriteLine("Invalid month number");
                //        break;
                //}

                // 12-Write a program to create a Simple Calculator.


                //13- Write a program to allow the user to enter a string and print the
                // REVERSE of it.
                string inputString = Console.ReadLine();
                for (int X = inputString.Length - 1; X >= 0; --X)
                {
                    Console.WriteLine(inputString[X]);

                }
                // 14- Write a program to allow the user to enter int and print the REVERSED
                //  of it.
                int inputInt = int.Parse(Console.ReadLine());
                string reversedInt = inputInt.ToString();
                for (int I = reversedInt.Length - 1; I >= 0; --I)
                {
                    Console.WriteLine(reversedInt[I]);


                }
                //15- Write a program in C# Sharp to find prime numbers within a range of numbers.

                static bool IsPrime(int n)      // Method to check if a number is prime
                {
                    if (n < 2) return false;
                    for (int i = 2; i * i <= n; i++)

                        if (n % i == 0) return false;
                    return true;
                }

                int startRange = int.Parse(Console.ReadLine());

                int endRange = int.Parse(Console.ReadLine());
                for (int J = startRange; J <= endRange; J++)
                {
                    if (IsPrime(J))
                        Console.Write(J + " ");
                }
                Console.WriteLine();

                //16- . Write a program in C# Sharp to convert a decimal number into binary without using an array.

                Console.Write("Enter a number to convert : ");
                int number = int.Parse(Console.ReadLine());
                int original = number;

                long binary = 0;
                long place = 1;

                while (number > 0)
                {
                    int remainder = number % 2;
                    binary += remainder * place;
                    place *= 10;
                    number /= 2;
                }

                Console.WriteLine($"The Binary of {original} is {binary}.");

                // 17- Create a program that asks the user to input three points (x1, y1),(x2, y2), and(x3, y3), and determines whether these points lie on a
                //single straight line.

                Console.Write("Enter x1: ");
                double x1 = double.Parse(Console.ReadLine());
                Console.Write("Enter y1: ");
                double y1 = double.Parse(Console.ReadLine());

                Console.Write("Enter x2: ");
                double x2 = double.Parse(Console.ReadLine());
                Console.Write("Enter y2: ");
                double y2 = double.Parse(Console.ReadLine());
                Console.Write("Enter x3: ");
                double x3 = double.Parse(Console.ReadLine());
                Console.Write("Enter y3: ");
                double y3 = double.Parse(Console.ReadLine());

                double left = (y2 - y1) * (x3 - x1);
                double right = (y3 - y1) * (x2 - x1);

                if (left == right)
                    Console.WriteLine("The three points lie on a single straight line.");
                else
                    Console.WriteLine("The three points do NOT lie on a single straight line.");

                //18- Within a company, the efficiency of workers is evaluated based on theduration required to complete a specific task.A worker's efficiency levelis determined as follows:
                //If the worker completes the job within 2 to 3 hours, they are consideredhighly efficient.
                //- If the worker takes 3 to 4 hours, they are instructed to increase theirspeed.
                //- If the worker takes 4 to 5 hours, they are provided with training to
                //enhance their speed.
                //- If the worker takes more than 5 hours, they are required to leave the
                //company.
                //To calculate the efficiency of a worker, the time taken for the task is
                //obtained via user input from the keyboard.

                Console.Write("Enter the time taken (in hours): ");
                double time = double.Parse(Console.ReadLine());

                if (time <= 3)
                    Console.WriteLine("Highly efficient.");
                else if (time <= 4)
                    Console.WriteLine("You should increase your speed.");
                else if (time <= 5)
                    Console.WriteLine("You will be provided with training to enhance your speed.");
                else
                    Console.WriteLine("You are required to leave the company.");

                //.19- Write a program that prints an identity matrix using for loop, inother words takes a value n from the user and shows the identity table of size n* n.
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());

                for (int Q = 0; Q < n; Q++)
                {
                    for (int Z = 0; Z < n; Z++)
                    {
                        if (Q == Z)
                            Console.Write("1 ");
                        else
                            Console.Write("0 ");
                    }
                    Console.WriteLine();
                }
                //20- Write a program in C# Sharp to find the sum of all elements of the array.
                int[] arr = { 1, 2, 3, 4, 5 };
                int sum = 0;

                for (int C = 0; C < arr.Length; C++)
                {
                    sum += arr[C];
                }

                Console.WriteLine($"The sum of all elements in the array is: {sum}");


                //   Console.WriteLine($"The sum of all elements in the array is:  {arr.Sum()}");

                //21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

                Console.Write("Enter the size of the arrays: ");
                int N = int.Parse(Console.ReadLine());

                int[] arr1 = new int[N];
                int[] arr2 = new int[N];
                int[] merged = new int[2 * N];

                Console.WriteLine("Enter the elements of the first array (ascending order):");
                for (int x = 0; x < N; x++)
                    arr1[x] = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the elements of the second array (ascending order):");
                for (int x = 0; x < N; x++)
                    arr2[x] = int.Parse(Console.ReadLine());

                int i = 0, j = 0, k = 0;


                while (i < N && j < N)
                {
                    if (arr1[i] <= arr2[j])
                        merged[k++] = arr1[i++];
                    else
                        merged[k++] = arr2[j++];
                }


                while (i < N)
                    merged[k++] = arr1[i++];

                while (j < N)
                    merged[k++] = arr2[j++];

                Console.WriteLine("The merged array in ascending order is:");
                for (int x = 0; x < 2 * N; x++)
                    Console.Write(merged[x] + " ");
                Console.WriteLine();



                //22- Write a program in C# Sharp to count the frequency of each element of an array.
                //23- Write a program in C# Sharp to find maximum and minimum element in an array
                int[] arr3 = new int[4];
                Console.WriteLine("Enter 4 elements for the array:");
                for (int i1 = 0; i1 < arr3.Length; i1++)
                {
                    arr3[i1] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"the Max of rthe array is: {arr3.Max()}");
                Console.WriteLine($"the Min of rthe array is: {arr3.Min()}");

                // 24- Write a program in C# Sharp to find the second largest element in an array.

                int[] array = { 12, 35, 1, 10, 34, 1 };

                int largest = arr[0];
                int? second = null;

                for (int y = 1; y < array.Length; y++)
                {
                    if (array[y] > largest)
                    {

                        second = largest;
                        largest = array[y];
                    }
                    else if (array[y] < largest && (second == null || array[y] > second))
                    {

                        second = array[y];
                    }
                }

                if (second == null)
                    Console.WriteLine("No second largest element");
                else
                    Console.WriteLine("second largest element: " + second);

                //25-. Consider an Array of Integer values with size N, having values a in this Example

                Console.Write("Enter the number of elements: ");
                int M = int.Parse(Console.ReadLine());

                int[] arr5 = new int[M];
                Console.WriteLine("Enter the elements:");
                for (int D = 0; D < M; D++)
                    arr5[D] = int.Parse(Console.ReadLine());

                int maxDistance = -1;

                for (int D = 0; D < M; D++)
                {
                    for (int Q = D + 1; Q < M; Q++)
                    {
                        if (arr5[D] == arr5[Q])
                        {
                            int distance = Q - D - 1;
                            if (distance > maxDistance)
                                maxDistance = distance;
                        }
                    }

                }

                // 26 Given a list of space separated words, reverse the order of the words. Console.Write("Enter the sentence: ");
                string input = Console.ReadLine();

                string[] words = input.Split(' ');
                Array.Reverse(words);
                Console.WriteLine(string.Join(" ", words));

                //27- Write a program to create two multidimensional arrays of same size  Accept value from user and store them in first array. Now copy all the
                //elements of first array on second array and print second array.
                Console.Write("Enter the number of rows: ");
                int rows = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of columns: ");
                int cols = int.Parse(Console.ReadLine());

                int[,] first = new int[rows, cols];
                int[,] sec = new int[rows, cols];


                for (int H = 0; H < rows; H++)
                {
                    for (int K = 0; K < cols; K++)
                    {
                        Console.Write($"Enter element [{H},{K}]: ");
                        first[H, K] = int.Parse(Console.ReadLine());
                    }
                }

                // copy elements to the second array
                for (int R = 0; R < rows; R++)
                    for (int C = 0; C < cols; C++)
                        sec[R, C] = first[R, C];


                Console.WriteLine("Second array:");
                for (int Q = 0; Q < rows; Q++)
                {
                    for (int C = 0; C < cols; C++)
                        Console.Write(sec[Q, C] + " ");
                    Console.WriteLine();
                }
                //28- Write a Program to Print One Dimensional Array in Reverse Order

                Console.Write("Enter the number of elements: ");
                int U = int.Parse(Console.ReadLine());

                int[] arr6 = new int[U];
                Console.WriteLine("Enter the elements:");
                for (int T = 0; T < U; T++)
                    arr6[T] = int.Parse(Console.ReadLine());

                Console.WriteLine("Array in reverse order:");
                for (int T = U - 1; T >= 0; T--)
                    Console.Write(arr6[T] + " ");



            }









        }
    }

