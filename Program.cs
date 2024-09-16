namespace Uppgift_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mina två objekt
            Hälsning newHälsning = new Hälsning();
            Tjena newTjena = new Tjena();
            Polymorfism newPolymorfism = new Polymorfism();
            Tv newTV = new Tv();
            Dator newDator = new Dator();

            Console.WriteLine("Ange arv, polymorfism, abstraktion eller inkapsling");
            string val = Console.ReadLine();


            /*
            newHälsning.hej();
            newTjena.hej();
            newTjena.käka();
            newPolymorfism.hej();
            newTV.el();
            newDator.el();

            // Läs in användarnamn
            Console.Write("Ange användarnamn: ");
            string username = Console.ReadLine();

            // Läs in lösenord
            Console.Write("Ange lösenord: ");
            string password = Console.ReadLine();

            // Skapa en ny User
            Login user1 = new Login(username, password);

            // Bekräfta att användaren skapades korrekt
            Console.WriteLine($"Användarnamn: {user1.Username}");
            Console.WriteLine($"Lösenord: {user1.Password}");
            */


            if (val == "arv")
            {
                newHälsning.hej();
                newTjena.hej();
                newTjena.käka();
            }
            else if (val == "polymorpism")
            {
                newPolymorfism.hej();
            }
            else if (val == "abstraktion")
            {
                newTV.el();
                newDator.el();
            }
            else if(val == "inkapsling")
            {
                Console.Write("Ange användarnamn: ");
                string username = Console.ReadLine();

                // Läs in lösenord
                Console.Write("Ange lösenord: ");
                string password = Console.ReadLine();

                // Skapa en ny User
                Login user1 = new Login(username, password);

                // Bekräfta att användaren skapades korrekt
                Console.WriteLine($"Användarnamn: {user1.Username}");
                Console.WriteLine($"Lösenord: {user1.Password}");
            }
            else
            {
                Console.WriteLine("Fel värde, försök igen");
            }

        }
    }
}
