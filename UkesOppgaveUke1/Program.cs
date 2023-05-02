namespace UkesOppgaveUke1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "! " + "Your new hobby is " + GetRandomHobby());
        }

        static string GetRandomHobby()
        {
            string[] hobby = { "Gaming", "Dancing", "Fishing", "Sky diving", "Tennis", "Badminton", "Hunting", "Gardening" };

            Random random = new();
            int number = random.Next(0, hobby.Length);
            return hobby[number];
        }
    }
}