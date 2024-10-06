using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер простого числа: ");
        int number = int.Parse(Console.ReadLine());

        int x = FInedX(number);

        Console.WriteLine($"Данное число {number} имеет номер {x}");
    }

    static int FInedX(int number)
    {
        int count = 0;
        int num = 1;

        while (count < number)
        {
            num = num +1;
            if (chislox(num))
            {
                count=count+1;
            }
        }

        return num;
    }



    static bool chislox(int num)
    {
        if (num < 2)
            return false;

        for (int i = 2; i <= num / i;
            
            i=i+1

            )
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
}






