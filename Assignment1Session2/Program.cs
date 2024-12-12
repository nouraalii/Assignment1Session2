namespace Assignment1Session2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            ////Write a program that allows the user to enter a number then print it.
            //Console.WriteLine("Please enter a number:");
            //int Number = int.Parse(Console.ReadLine());
            //Console.WriteLine("The Number is: " + Number); 
            #endregion


            #region Question2
            ////Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            ////First Way
            //string NonNumeric = "123abc";
            //int Number = Convert.ToInt32(NonNumeric);
            //Console.WriteLine(NonNumeric);
            ////What will happened:Invalid because the non-numeric 

            ////second way 
            //string NonNumeric = "123abc";
            //int Number;
            //bool Flag = int.TryParse(NonNumeric, out Number);
            //Console.WriteLine(Number);
            //Console.WriteLine(Flag);
            #endregion


            #region Question3
            ////Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //float Number1 = 4.5f;
            //float Number2 = 5.2f;
            //float result = Number1 + Number2;
            //Console.WriteLine(result);
            #endregion


            #region Question4
            ////Write C# program that Extract a substring from a given string.
            //string input = "programming";
            //string substring = input.Substring(0, 7);
            //Console.WriteLine(substring);
            #endregion


            #region Question5
            ////Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int Number1 = 10;
            //int Number2 = Number1;
            //Number1 = 20;
            //Console.WriteLine(Number1);
            //Console.WriteLine(Number2);
            ////Number1=20
            ////Number2=10
            #endregion


            #region Question6
            ////Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //Point p1 = new Point();
            //Point p2 = new Point();
            //p2.X = 10;
            //p1 = p2;
            //Console.WriteLine(p1.X);
            //Console.WriteLine(p2.X);
            ////will print for p1.x =10 and p2.x=10 because p1 and p2 refernce to the same address 
            #endregion


            #region Question7
            ////Write C# program that take two string variables and print them as one variable 
            //Console.WriteLine("Enter First string");
            //string Input1 = Console.ReadLine();
            //Console.WriteLine("Enter Second string");
            //string Input2 = Console.ReadLine();
            //Console.WriteLine(Input1 + " " + Input2);
            #endregion


            #region Question8
            ////Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100.
            //double Interest, principal = 25.5, rate = 5, time = 3.5;
            //Interest = (principal * rate * time) / 100;
            //Console.WriteLine("The simple Interest : " + Interest);
            #endregion


            #region Question9
            ////Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is BMI = (Weight) / (Height * Height)
            //double BMI, weight, height;
            //weight = 50.5;
            //height = 1.65;
            //BMI = (weight) / (height * height);
            //Console.WriteLine("The value of BMI :" + BMI);
            #endregion


            #region Question10
            ////Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".
            //Console.WriteLine("Enter the temperature in degrees:");
            //int temperature = Convert.ToInt32(Console.ReadLine());
            //string result = (temperature < 10) ? "Just Cold" : (temperature > 30) ? "Just Hot" : "Just Good";
            //Console.WriteLine("The weather is: " + result);
            #endregion


            #region Question11
            ////Write a program that takes the date from the user and displays it in various formats using string interpolation.
            //Console.WriteLine("Enter the day:");
            //string day = Console.ReadLine();
            //Console.WriteLine("Enter the month:");
            //string month = Console.ReadLine();
            //Console.WriteLine("Enter the year:");
            //string year = Console.ReadLine();
            //Console.WriteLine($"Today's date : {day} , {month} , {year}");
            //Console.WriteLine($"Today's date : {day} / {month} / {year}");
            //Console.WriteLine($"Today's date : {day} – {month} – {year}"); 
            #endregion


            #region Question12
            ////What is the output of the following C# code?
            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

            ////c) The event is on 06/14/2024 
            #endregion


            #region Question13
            ////Which of the following statements is correct about the C#.NET code snippet given below?
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d);
            ////f)A value 1 will be assigned to d. 
            #endregion


            #region Question14
            ////Which of the following is the correct output for the C# code given below?
            //Console.WriteLine(13 / 2 + " " + 13 % 2);

            ////d)6 1 
            #endregion


            #region Question15
            ////What will be the output of the C# code given below?
            //int num = 1, z = 5;
            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);
            ////d)7 7 
            #endregion
        }
    }
}
