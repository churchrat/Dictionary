namespace Minerbook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> minerbook = new Dictionary<string, int>();
            string input = null;
            int quantity = 0;
            do
            {
                input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                quantity = int.Parse(Console.ReadLine());
                minerbook.Add(input, quantity);

            } while (input != "stop");
            foreach (var pair in minerbook)
            {
                Console.WriteLine($"{pair.Key} ======> {pair.Value}");
            }
        }
    }
}
