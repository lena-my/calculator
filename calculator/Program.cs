
/* ## Une calculette

Réalise une calculette basique avec cinq fonctions :

* Add qui additionne deux nombres flottants
* Subtract qui soustrait deux nombres flottants
* Multiply qui multiplie deux nombres flottants
* Divide qui divise deux nombres flottants
* Modulo qui renvoie le reste d'une division de nombres entiers

Fais précéder chacune des fonctions du mot-clé static.


## Critères de validation

* Un lien vers ta solution GitHub
* Une boucle infinie permet à l'utilisateur d'utiliser la calculette plusieurs fois sans relancer le programme
* Un message d'erreur s'affiche dans le cas où l'utilisateur rentre une mauvaise opération */

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