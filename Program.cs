namespace music
{
    internal class Program
    {
        static void Main(string[] args)
        {
            music a1 = new music("StrayKids", 32.38, "The sound");
            music a2 = new music("KARD", 18.03, "Re");

            Console.WriteLine(a1.length + a2.length);  

        }
    }
}