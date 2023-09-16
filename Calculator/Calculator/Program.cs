using System.ComponentModel.Design;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        double result;
        char a;
        char again;
        link1:
        Console.WriteLine("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите оператор(+,-,*,/): ");
        a = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        switch(a)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"Сумма {num1} + {num2} = {result}");
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine($"Вычитание {num1} - {num2} = {result}");
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine($"Произведение {num1} * {num2} = {result}");
                break;
            case '/':
                result = num1 / num2;
                Console.WriteLine($"Частное {num1} / {num2} = {result}");
                break;
            default: 
                Console.WriteLine("Неизвестный оператор");
                break;
        }
        Console.WriteLine("Желаете продолжить?(y/n)");
        again = Convert.ToChar(Console.ReadLine());
        if (again == 'y') goto link1; 
        else goto link2;
        link2:
        Console.WriteLine("Удачи!");
    }
}