namespace Tunnitöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere tulemast!");
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("tere tulemast " + i);

                int a = 1;

                while (a <= 3)
                {
                    //uus while
                    int b = 1;
                    while (b <= 3)
                    {
                        Console.Write(b + " ");
                        b++;
                    }

                    Console.WriteLine();
                    a++;

                    Console.WriteLine("Sisesta esimene number");
                    float firstNumber = float.Parse(Console.ReadLine());

                    Console.WriteLine("Sisesta tehe");
                    string operation = Console.ReadLine();

                    Console.WriteLine("Sisesta teine number");
                    float secondNumber = float.Parse(Console.ReadLine());


                    switch (operation)
                    {
                        case "+":
                            Console.WriteLine($"Tulemus: {firstNumber + secondNumber}");
                            break;

                        case "-":
                            Console.WriteLine($"Tulemus: {firstNumber - secondNumber}");
                            break;

                        case "*":
                            Console.WriteLine($"Tulemus: {firstNumber * secondNumber}");
                            break;

                        case "/":
                            if (secondNumber == 0)
                            {
                                Console.WriteLine("Nulliga jagamine ei ole lubatud!");
                            }
                            else
                            {
                                Console.WriteLine($"Tulemus: {firstNumber / secondNumber}");
                            }
                            break;

                        default:
                            Console.WriteLine("Tundmatu tehe!");
                            break;

                    }
                }
            }
        }
    }
}
