namespace VigadeParandus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vigade parandus");
            string intput = Console.ReadLine();

            Console.WriteLine("Vajuta numbrit");
            Console.WriteLine("1. Tagurpidi Püramiid");
            Console.WriteLine("2. Ristkülik");
            Console.WriteLine("3. Püramiid");

            string input = Console.ReadLine();
            //puhastab konsooli eelnevast tekstist
            Console.Clear();

            switch (intput)
            {
                case "1":
                    //meetodi v'lja kutsumine
                    UpsidedownPyramiid();
                    break;

                case "2":
                    Rectangle();
                    break;

                default:
                    Console.WriteLine("Sellist valikut ei ole");
                    break;
                
            }
        }

        static void UpsidedownPyramiid()
        {
            Console.WriteLine("Sisesta kõrgus");
            int i, j, n;
            n = Convert.ToInt32(Console.ReadLine());


            for (i = n - 0; i >= 1; i--)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.WriteLine(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }


        static void Rectangle()
        {
            Console.WriteLine("Sisesta pikkus");
            int row = int.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta laius");
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("");
            }

            int area = row * width;
            int around = 2 * (row + width);

            Console.WriteLine("Pindala on " + area);
            Console.WriteLine("Ümbermõõt on " + around);
        }
    }

        static void UpsidedownPyramiid()


        static void Rectangle()


        static void Pyramiid()
        {
            Console.WriteLine("");
            Console.WriteLine("Sisesta püramiidi kõrgus: ");

            int i, j, n;
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n - 1; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for(i = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
        }
    }
}