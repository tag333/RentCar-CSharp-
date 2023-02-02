
namespace CarRent.Writers
{
    public class ClientWrite : IWriter
    {
        public static int CountWithLaw = 0;

        private Raport Raport;

        private readonly IEnumerable<Client> clients;

        public ClientWrite (IEnumerable<Client> clients, int indexOfGroup, string letterOfGroup)
        {
            this.clients = clients;

            Raport = new();

            Raport.indexOfGroup = indexOfGroup;
            Raport.letterOfGroup = letterOfGroup;
        }

        public void FillHeader()
        {
            Raport.Header =
                $"SQL OF CLIENT(IDEF_KEY): {Raport.indexOfGroup}{Raport.letterOfGroup}                          CURRENT DAT: {DateTime.Now}\n";

            Raport.Header +=
                "\n------------------------------------------------------------------\n";
        }

        public void FillBody()
        {
            Raport.Body =
                string.Join(Environment.NewLine,
                clients.Select(e =>
                $"Client ID: {e.Client_ID}\t\tClient Name: {e.Name}\t\tClient Age: {e.Age}\t\t Client driver law: {e.DriverLawSustain()}"));
        }

        public void FillFooter()
        {
            Raport.Footer =
                "\n------------------------------------------------------------------\n";

            foreach (var item in clients)
            {
                if (item.DriverLaw == true)
                {
                    CountWithLaw++;
                }
            }

            Raport.Footer +=
                $"Count of clients: {clients.Count()}\t Count of client with law {CountWithLaw}";
        }

        public Raport GetRaport()
        {
            Raport raport = Raport;

            Raport = new();

            return raport;
        }
    }
}

