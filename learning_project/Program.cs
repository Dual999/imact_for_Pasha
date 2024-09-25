using System;
class Program
{
    static void Main()
    {
        //Console.WriteLine("vvodi imya!");
        //string? name = Console.ReadLine();
        //Console.WriteLine("vvodi familiyu!");
        //string? lastname = Console.ReadLine();
        //Console.WriteLine("vvodi otchestvo!");
        //string? patronymic = Console.ReadLine();
        //Console.Write($"Привет {name} {lastname} {patronymic}");

        Console.WriteLine("vvodi 1 4islo!");
        string n1 = Console.ReadLine();

        Console.WriteLine("vvodi 2 4islo!");
        string n2 = Console.ReadLine();

        Console.WriteLine("4e budem delaTb? (+,-,*,/):");
        string step = Console.ReadLine();


        int chislo1 = Convert.ToInt32(n1);
        int chislo2 = Convert.ToInt32(n2);
        decimal resultat = 0;

        switch (step)
        {
            case "+":

                resultat = chislo1 + chislo2;
                break;

            case "-":

                resultat = chislo1 - chislo2;

                break;

            case "*":


                resultat = chislo1 * chislo2;

                break;

            case "/":


                if (chislo2 != 0)

                {
                    resultat = Convert.ToDecimal(chislo1 / chislo2);

                }
                else
                { Console.WriteLine("Ты чё, на ноль делить нельзя"); }
                break;

            default:
                Console.WriteLine("Ты че то не то вводишь дружок");
                break;
        }
        Console.WriteLine($"Получилось {Convert.ToDecimal(resultat)}");
    }
}
    

