using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to read: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 10 && number >= 0)
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
            }
        }
        else if (number >= 10 && number < 20)
        {
            switch (number)
            {
                case 10:
                    Console.WriteLine("ten");
                    break;
                case 11:
                    Console.WriteLine("eleven");
                    break;
                case 12:
                    Console.WriteLine("twelve");
                    break;
                case 13:
                    Console.WriteLine("thirteen");
                    break;
                case 14:
                    Console.WriteLine("fourteen");
                    break;
                case 15:
                    Console.WriteLine("fifteen");
                    break;
                case 16:
                    Console.WriteLine("sixteen");
                    break;
                case 17:
                    Console.WriteLine("seventeen");
                    break;
                case 18:
                    Console.WriteLine("eighteen");
                    break;
                case 19:
                    Console.WriteLine("nineteen");
                    break;
            }
        }
        else if (number >= 20 && number < 100)
        {
            int tens = number / 10;
            int ones = number % 10;

            string tensWord = "";
            string onesWord = "";

            switch (tens)
            {
                case 2:
                    tensWord = "twenty";
                    break;
                case 3:
                    tensWord = "thirty";
                    break;
                case 4:
                    tensWord = "forty";
                    break;
                case 5:
                    tensWord = "fifty";
                    break;
                case 6:
                    tensWord = "sixty";
                    break;
                case 7:
                    tensWord = "seventy";
                    break;
                case 8:
                    tensWord = "eighty";
                    break;
                case 9:
                    tensWord = "ninety";
                    break;
            }

            switch (ones)
            {
                case 1:
                    onesWord = "one";
                    break;
                case 2:
                    onesWord = "two";
                    break;
                case 3:
                    onesWord = "three";
                    break;
                case 4:
                    onesWord = "four";
                    break;
                case 5:
                    onesWord = "five";
                    break;
                case 6:
                    onesWord = "six";
                    break;
                case 7:
                    onesWord = "seven";
                    break;
                case 8:
                    onesWord = "eight";
                    break;
                case 9:
                    onesWord = "nine";
                    break;
            }

            Console.WriteLine(tensWord + " " + onesWord);
        }
        else if (number >= 100 && number < 1000)
        {
            int hundreds = number / 100;
            int tens = (number % 100) / 10;
            int ones = (number % 100) % 10;

            string hundredsWord = "";
            string tensWord = "";
            string onesWord = "";

            switch (hundreds)
            {
                case 1:
                    hundredsWord = "one hundred";
                    break;
                case 2:
                    hundredsWord = "two hundred";
                    break;
                case 3:
                    hundredsWord = "three hundred";
                    break;
                case 4:
                    hundredsWord = "four hundred";
                    break;
                case 5:
                    hundredsWord = "five hundred";
                    break;
                case 6:
                    hundredsWord = "six hundred";
                    break;
                case 7:
                    hundredsWord = "seven hundred";
                    break;
                case 8:
                    hundredsWord = "eight hundred";
                    break;
                case 9:
                    hundredsWord = "nine hundred";
                    break;
            }

            switch (tens)
            {
                case 2:
                    tensWord = "twenty";
                    break;
                case 3:
                    tensWord = "thirty";
                    break;
                case 4:
                    tensWord = "forty";
                    break;
                case 5:
                    tensWord = "fifty";
                    break;
                case 6:
                    tensWord = "sixty";
                    break;
                case 7:
                    tensWord = "seventy";
                    break;
                case 8:
                    tensWord = "eighty";
                    break;
                case 9:
                    tensWord = "ninety";
                    break;
            }

            switch (ones)
            {
                case 1:
                    onesWord = "one";
                    break;
                case 2:
                    onesWord = "two";
                    break;
                case 3:
                    onesWord = "three";
                    break;
                case 4:
                    onesWord = "four";
                    break;
                case 5:
                    onesWord = "five";
                    break;
                case 6:
                    onesWord = "six";
                    break;
                case 7:
                    onesWord = "seven";
                    break;
                case 8:
                    onesWord = "eight";
                    break;
                case 9:
                    onesWord = "nine";
                    break;
            }

            Console.WriteLine(hundredsWord + " and " + tensWord + " " + onesWord);
        }
        else
        {
            Console.WriteLine("Out of ability");
        }
    }
}