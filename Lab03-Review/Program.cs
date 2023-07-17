using System;

namespace Lab03_Review
{
    using System;
    using System.Reflection.Metadata;

    namespace Lab03_Review
    {
        public class Program
        {
            static void Main(string[] args)
            {
                bool selection = false;

                while (selection == false)
                {
                    Console.WriteLine("Welcome to my Lab 3 Review, here you can test my code and make sure I know something!");

                    //Stole this sleep idea from Jared :)
                    Console.WriteLine("Please press a key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    // Choices for the program
                    Console.WriteLine("Please Select a Following Option");
                    Console.WriteLine("Enter 1 to run Challenge 1");
                    Console.WriteLine("Enter 2 to run Challenge 2");
                    Console.WriteLine("Enter 3 to run Challenge 3");
                    Console.WriteLine("Enter 4 to run Challenge 4");
                    Console.WriteLine("Enter 5 to run Challenge 5");
                    Console.WriteLine("Enter 6 to run Challenge 6");
                    Console.WriteLine("Enter 7 to run Challenge 7");
                    Console.WriteLine("Enter 8 to run Challenge 8");
                    Console.WriteLine("Enter 9 to run Challenge 9");
                    Console.WriteLine("Enter 10 to exit :(");

                    string selectionInput = Console.ReadLine();

                    if (selectionInput == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter 3 numbers separated by spaces:");
                        string input = Console.ReadLine();
                        int product = Challenge1(input);
                        
                        Console.WriteLine("Product: " + product);
                        Thread.Sleep(500);
                    }
                    else if (selectionInput == "2")
                    {
                        //Challenge 2
                        Console.Clear();
                        Console.WriteLine("Please Enter a number between 2-10: ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        int[] array = new int[input];
                        for (int i = 0; i < input; i++)
                        {
                            Console.WriteLine(i + 1 + " of " + input + " - Enter a Number: ");
                            array[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        int product = Challenge2(array, input);
                        
                        Console.WriteLine("Your average between your number is : " + product);
                        Thread.Sleep(500);
                    }
                    else if (selectionInput == "3")
                    {
                        Challenge3();
                    }
                    else if (selectionInput == "4")
                    {
                        Console.WriteLine("Lets find the mode of your numbers!");
                        Console.WriteLine("Enter multiple numbers separated by spaces:");
                        string input = Console.ReadLine();

                        // Split the input string into an array of numbers
                        string[] numberStrings = input.Split(' ');
                        int[] numbers = Array.ConvertAll(numberStrings, int.Parse);

                        int result = Challenge4(numbers);
                        Console.WriteLine("The number that appeared the most times is: " + result);
                    }
                    else if (selectionInput == "5")
                    {
                        Console.WriteLine("Let sort your array!");
                        Console.WriteLine("Enter multiple numbers separated by spaces:");
                        string input = Console.ReadLine();

                        // Split the input string into an array of numbers
                        string[] numberStrings = input.Split(' ');
                        int[] numbers = Array.ConvertAll(numberStrings, int.Parse);
                        int result = Challenge5(numbers);
                        Console.WriteLine("Your maximum value is : " + result);
                        
                    }
                    else if (selectionInput == "6")
                    {
                        Console.WriteLine("Input a word to put into the file words.txt: ");
                        string input = Console.ReadLine();
                        Challenge6(input);
                    }
                    else if (selectionInput == "7")
                    {
                        Console.WriteLine("Reading Your File....");
                        Thread.Sleep(1500);
                        string results = Challenge7();
                        Console.WriteLine(results);
                    }

                    else if (selectionInput == "8")
                    {
                        string content = File.ReadAllText("/Users/connerthompson/Documents/Coding Central/GitHub/Lab03-Review/Lab03-Review/words.txt");
                        Console.WriteLine("This is the content in your file, what would you like to remove?");
                        Console.WriteLine(content);
                        string userInput = Console.ReadLine();
                        Challenge8(userInput);
                    }
                    else if (selectionInput == "9")
                    {
                        Console.WriteLine("Enter a sentence:");
                        string input = Console.ReadLine();
                        string[] array = Challenge9(input);
                        Console.WriteLine("Word Lengths:");
                        foreach (string word in array)
                        {
                            Console.WriteLine(word);
                        }
                    }
                    else if (selectionInput == "10")
                    {
                        selection = true;
                    }
                }
            }

            public static int Challenge1(string input)
            {
                string[] numbers = input.Split(' ');

                if (numbers.Length < 3)
                    return 0;

                int product = 1;

                for (int i = 0; i < 3; i++)
                {
                    if (i >= numbers.Length || !int.TryParse(numbers[i], out int number))
                        number = 1;

                    product *= number;
                }

                return product;
            }
            public static int Challenge2(int[] array, int input)
            {
                int total = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    total += array[i];
                }
                int value = total / input;

                return value;
            }
            public static void Challenge3()
            {
                int size = 9;

                int middleRow = (size - 1) / 2;
                for (int i = 0; i <= middleRow; i++)
                {
                  
                    for (int j = 0; j < middleRow - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j < 2 * i + 1; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }

                for (int i = middleRow - 1; i >= 0; i--)
                {
     
                    for (int j = 0; j < middleRow - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j < 2 * i + 1; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }
            public static int Challenge4(int[] array)
            {
                Dictionary<int, int> numberCounts = new Dictionary<int, int>();

                foreach (int number in array)
                {
                    if (numberCounts.ContainsKey(number))
                    {
                        numberCounts[number]++;
                    }
                    else
                    {
                        numberCounts[number] = 1;
                    }
                }

                int maxCount = 0;
                int mostFrequentNumber = array[0]; 

                foreach (KeyValuePair<int, int> kvp in numberCounts)
                {
                    if (kvp.Value > maxCount)
                    {
                        maxCount = kvp.Value;
                        mostFrequentNumber = kvp.Key;
                    }
                }

                return mostFrequentNumber;
            }
            public static int Challenge5(int[] array)
            {
                bool switched;
                int greatestNumber = 0;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    switched = false;

                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                            switched = true;
                        }
                    }
                    if (!switched)
                    {
                        //Break because we want out if its already been swapped
                        break;
                    }
                for (int k = 0; k < array.Length; k++)
                    {
                        
                        if (array[k] > greatestNumber)
                        {
                            greatestNumber = array[k];
                        }

                    }

                }

                return greatestNumber;
            }
            public static void Challenge6(string input)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter("/Users/connerthompson/Documents/Coding Central/GitHub/Lab03-Review/Lab03-Review/words.txt"))
                    {
                        writer.Write(input);
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Error: File path not found");
                }
            }
            public static string Challenge7()
            {
                string content = File.ReadAllText("/Users/connerthompson/Documents/Coding Central/GitHub/Lab03-Review/Lab03-Review/words.txt");
                return content;
            }
            public static void Challenge8(string word)
            {
                string filePath = "/Users/connerthompson/Documents/Coding Central/GitHub/Lab03-Review/Lab03-Review/words.txt";
                string content = File.ReadAllText(filePath);
                string updatedContent = content.Replace(word, "");
                File.WriteAllText(filePath, updatedContent);

            }
            public static string[] Challenge9(string sentence)
            {
                string[] words = sentence.Split(' ');
                string[] wordLengths = new string[words.Length];

                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];
                    int wordLength = word.Length;
                    wordLengths[i] = $"{word}: {wordLength}";
                }

                return wordLengths;

            }



        }
    }

}


