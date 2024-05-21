namespace Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string input = null;
            do
            {
                input = Console.ReadLine();
                string[] temp = (input.Split(' '));
                if (temp[0] == "A")
                {
                    if (phonebook.ContainsKey(temp[1]))
                    {
                        phonebook.Remove(temp[1]);
                    }
                    phonebook.Add(temp[1], temp[2]);
                }
                else if (temp[0] == "S")
                {
                    bool check = phonebook.ContainsKey(temp[1]);
                    if (check)
                    {
                        Console.WriteLine(temp[1]);
                        Console.WriteLine(phonebook[temp[1]]);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {temp[1]} does not exist. ");
                    }
                }
            } while (input != "END");
        }
    }
}

