namespace FileWordReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Luuletus");
        }

        static void FileWordReader()
        {
            string line;

            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/ingva/Desktop/luuletus.txt"))
                {
                    int cnt = 0; //rea muutuja
                    while (sr.EndOfStream == false)
                    {
                        ++cnt; //rea nr suurendamine 1 ühiku võrra
                        line = sr.ReadLine(); //teksti lugemine txt faillist
                        int pikkus = line.Length; //sõna lugemine, kui sõne pikkusena
                        Console.WriteLine(cnt + " " + pikkus);
                    }
                    sr.Close();//faili lugemise lõpetamine
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Faili  ei saa lugeda");
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}