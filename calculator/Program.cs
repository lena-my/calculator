using System.Globalization;
using System.Transactions;

while (true)
{

    /* Enter the first number */
    Console.WriteLine("Enter a number to calculate ");
    string number1ToParse = Console.ReadLine();

    if (IsANumber(number1ToParse))
    {
        Console.WriteLine("Enter the operator (+ or - or / or * or %)");
        string operatorToCalculate = Console.ReadLine();

        if (operatorToCalculate == "+" || operatorToCalculate == "-" || operatorToCalculate == "*" || operatorToCalculate == "/" || operatorToCalculate == "%")
        {
            Console.WriteLine("Enter the second number ");
            string number2ToParse = Console.ReadLine();


            if (IsANumber(number2ToParse))
            {
                float number1 = float.Parse(number1ToParse);
                float number2 = float.Parse(number2ToParse);

                if (operatorToCalculate == "+")
                {
                    Add(number1, number2);
                }

                if (operatorToCalculate == "-")
                {
                    Substract(number1, number2);
                }

                if (operatorToCalculate == "*")
                {
                    Multiply(number1, number2);
                }

                if (operatorToCalculate == "/")
                {
                    Divide(number1, number2);
                }

                if (operatorToCalculate == "%")
                {
                    Modulo(number1, number2);
                }

            }
            else
            {
                Console.WriteLine("Invalid number. Try again.");
            }
        }
        else
        {
            Console.WriteLine("Invalid operator. Try again.");

        }

    }

    else
    {
        Console.WriteLine("Invalid number. Try again.");
    }
}




/***methods**/
static void Add(float a, float b)
{
    float result = a + b;
    Console.WriteLine($"{a} + {b} = {result}");
}

static void Substract(float a, float b)
{
    float result = a - b;
    Console.WriteLine($"{a} - {b} = {result}");
}

static void Multiply(float a, float b)
{
    float result = a * b;
    Console.WriteLine($"{a} * {b} = {result}");
}

static void Divide(float a, float b)
{
    float result = a / b;
    Console.WriteLine($"{a} / {b} = {result}");
}

static void Modulo(float a, float b)
{
    float result = a % b;
    Console.WriteLine($"{a} % {b} = {result}");
}

/* Tests if the entered number is a number */
static bool IsANumber(string input)
{
    bool isANumber = double.TryParse(input, out _);
    return isANumber;
}
