using System.ComponentModel.Design;
using System.Runtime.InteropServices;

internal class Program
{
        double result;
        char a; // имя должно передавать смысл переменной. например typeOfTransaction
        char again;
    // метод Main() не должен содержать функционала, в нем следует лишь вызывать нужные вам методы (а вот в них уже функционал)
    // общедуступные переменные следует объявлять как поля класса, а не переменные метода Main()
    private static void Main(string[] args)
    {
       
        link1: // в программе не должны еспользоваться якоря и оператор goto (говорила об этом на лекции)
        GetInputData ();
        Calc ();
        RepeatProgram();
        
    }
    static void RepeatProgram()
    {
        Console.WriteLine("Желаете продолжить?(y/n)");
        again = Convert.ToChar(Console.ReadLine()); // обработка исключения
        if (again == 'y') goto link1; // убрать якоря
        else goto link2;
        link2:
        Console.WriteLine("Удачи!");
    }
    static void Calc ()
    {
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
    }
    static void GetInputData ()
    {
        Console.WriteLine("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine()); // следовало добавить обработку исключения на случай, если не удалось конвертировать строку в число (например ввели дробное число или буквы)
        Console.WriteLine("Введите оператор(+,-,*,/): ");
        a = Convert.ToChar(Console.ReadLine()); // обработка исключения
        Console.WriteLine("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine()); // оюработка исключения
    }
}
