using System;
using System.Linq;


namespace BasicExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sum();
            // Greatest();
            // Greatest2();
            // PerimeterAreaCircle();
            // Div5Between2Numb();
            // GreaterOfTwo();
            // Sum5IfOk();
            // PrintNinputs(10);
            // PrintNinputs2(10);
            // MaxAndMin();
            // Triangle();
            // BinaryNotation();
            // RandomNumbers();
            FizzProgram();
            // Company();

        }

        // Conditional statements and loops
        //1. Write a program that reads from the console three numbers of type int and prints their sum.

        public static void Sum()
        {
            Console.WriteLine("Enter first Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third Number: ");
            int num3 = int.Parse(Console.ReadLine());
            int sum = 0;

            sum = num1 + num2 + num3;
            Console.WriteLine($"The sum of 3 numbers entered from the keyboard is { sum } ");

        }

        //.2 Write a program that reads five numbers from the console and prints the greatest of them.

        public static void Greatest()
        {
            Console.WriteLine("Enter first Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third Number: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter forth Number: ");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fifth Number: ");
            int num5 = int.Parse(Console.ReadLine());

            int[] numbers = { num1, num2, num3, num4, num5 };
            int biggestNumber = numbers.Max();

            Console.WriteLine($"The greatest number is { biggestNumber } ");



        }
        public static void Greatest2()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            int num4 = int.Parse(Console.ReadLine());
            Console.Write("Enter fifth number: ");
            int num5 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5) Console.WriteLine("{0} is the biggest.", num1);
            else if (num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5) Console.WriteLine("{0} is the biggest.", num2);
            else if (num3 > num1 && num3 > num2 && num3 > num4 && num3 > num5) Console.WriteLine("{0} is the biggest.", num3);
            else if (num4 > num1 && num4 > num2 && num4 > num3 && num4 > num5) Console.WriteLine("{0} is the biggest.", num4);
            else if (num5 > num1 && num5 > num2 && num5 > num3 && num5 > num4) Console.WriteLine("{0} is the biggest.", num5);
            else Console.WriteLine("There isn't a biggest number.");



        }

        //3. Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.

        public static void PerimeterAreaCircle()
        {
            Console.WriteLine("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;

            Console.WriteLine($"The perimeter is {perimeter}\nThe Area is {area}");
        }

        //4. Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist that 
        //are divisible with 5. such that the remainder of their division by 5 is 0.

        //Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.

        public static void Div5Between2Numb()
        {
            Console.WriteLine("Enter first Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                int aux = num1;
                num1 = num2;
                num2 = aux;
            }

            int howMany = 0;

            for (int i = num1; i <= num2; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                    howMany++;
                }
            }
            Console.WriteLine($"Between {num1} and {num2} the are {howMany} numbers divisible with 5.");

        }

        //5. Write a program that reads two numbers from the console and prints the greater of them.Solve the problem without 
        //using conditional statements and with conditional statements.

        public static void GreaterOfTwo()
        {
            Console.WriteLine("Enter first Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                Console.WriteLine("The greagest is {0}", num2);
            }
            else
            {
                Console.WriteLine("The greagest is {0}", num1);
            }

            Console.WriteLine($"The GREATEST OF ALL IS { Math.Max(num1, num2)}");
        }

        //6. Write a program that reads five integer numbers and prints their sum.If an invalid number is entered the program should prompt the user to enter another number(only once)

        static void Sum5IfOk() // make 2 chances for every entry!!!!
        {

            int chance = 0, i = 1, sum = 0;
            while (i <= 5 && chance < 2)
            {
                Console.WriteLine($"Input the {i} number!");
                if (int.TryParse(Console.ReadLine(), out int rightNumb))
                {
                    sum = sum + rightNumb;
                }
                else
                {
                    Console.WriteLine("Please enter a number!!! Last chance!!!");
                    chance++;
                    i--;
                }

                i++;
            }

            if (chance < 2)
            {
                Console.WriteLine($"Sum is {sum}");
            }
            else 
            {
                Console.WriteLine("ZERO chances!!!! Quit and Restart!!! ");
            }

        }

        //7. Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.\

        public static void PrintNinputs(int n)
        {
            for (int i = 1; i <= n; i++)

                Console.WriteLine(i);
        }



        //8. Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously.The number N should be read from the standard input.

        public static void PrintNinputs2(int n)
        {
            for (int i = 1; i <= n; i++)

                if (i % 3 == 1 || i % 7 == 1)
                {
                    Console.WriteLine(i);
                }
        }

        //9. Write a program that reads from the console a series of 5 integers and prints the smallest and largest of them.

        public static void MaxAndMin()
        {
            Console.WriteLine("Enter lenght of the Arr: ");
            int length = int.Parse(Console.ReadLine()); //get lenght
            int[] myArray = new int[length]; // inizialize
            for (int i = 0; i < length; i++)//add elem
            {
                Console.WriteLine("Add Elemen {0}", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Max is {0}\nMin is {1}", myArray.Max(), myArray.Min());

        }

        //10. Write program that outputs a triangle made of stars with variable size, depending on an input parameter.Look at the examples to get an idea. The input comes as a string number, which needs to be parsed to a number. The output is a series of lines printed on the console, forming a triangle of variable size.
        
        //Input 2:   
        //Output:    
        //*   
        //**
        //*
                
        static void Triangle()

        {


            Console.WriteLine("Please enter the input:");
            int input = int.Parse(Console.ReadLine());
            int a, b;

            for (a = 1; a <= input; a++)
            {
                for (b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (a = input - 1; a >= 0; a--)
            {
                for (b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        //11* . Write a program that converts a given number from decimal to binary notation (numeral system).

        static void BinaryNotation()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(number, 2);
            Console.WriteLine("The result is: " + binary);
        }


        //12*. Write a program that by a given integer N prints the numbers from 1 to N in random order

        static void RandomNumbers()
        {
            int[] numbers = new int[10];
            Random rnd = new Random();

            for (var i = 1; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(10);
            }

            foreach (var i in numbers)
            {
                Console.WriteLine(i.ToString());
            }
      
        }

        //13*. A program which iterates the integers from 1 to 50 For multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz".

        //Output : 
        //fizzbuzz
        //1
        //2
        //fizz
        //4 
        //buzz

        static void FizzProgram()
        {

            for (var i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else if (i % 3 == 0)
                {

                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }
        }


        //14. A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number. Write a program that reads information about the company and its manager and then prints it on the console.

        static void Company()
        {
            Console.WriteLine("Enter the name of the company:");
            string company = Console.ReadLine();
            string companyName = company;
            Console.WriteLine($"The name of the company is: {companyName}");
            string adress = "DN28, KM10, Valea Lupului, Iasi";
            Console.WriteLine($"The adress of the {company} company is: {adress}");
            string phoneNumber = "0232 253 100";
            Console.WriteLine($"The phone number of the {company} company is: {phoneNumber}");
            string faxNumber = "0232 256 200";
            Console.WriteLine($"The fax number of the {company} company is: {faxNumber}");
            string webSite = $"www.{companyName}.ro";
            Console.WriteLine($"The web site of the {company} company is: {webSite}");
            string managerName = "Serban";
            Console.WriteLine($"The name of the manager is: {managerName}");
            string managerSurname = "Cosmin";
            Console.WriteLine($"The surname of the manager is: {managerSurname}");
            string managerPhone = "0769 221 221";
            Console.WriteLine($"The manager phone number is: {managerPhone}");

        }
    }
}
