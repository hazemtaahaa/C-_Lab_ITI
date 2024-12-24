namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence:");

            string s = Console.ReadLine();


            Console.WriteLine(string.Join(' ', s.Split(' ').Reverse()));
            
           
           
        }
    }
}
