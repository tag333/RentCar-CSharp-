
using CarRent.Writers;

namespace CarRent
{
    class Program
    {
        static void Main()
        {

            List<Client> clients = new()
            {
                new Client(1, "Misha", 19, true),
                new Client(2, "Dasha", 15, false)
            };

            ClientWrite raport = new ClientWrite(clients, 2, "C");

            raport.FillBody();
            raport.FillFooter();
            raport.FillHeader();

            Console.WriteLine(raport.GetRaport());

            Console.Read();
        }
    }
}

