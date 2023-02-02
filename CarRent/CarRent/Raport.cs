using System.Text;

namespace CarRent
{
    public class Raport
    {
        public int indexOfGroup { get; set; }

        public string letterOfGroup { get; set; }

        public string Header { get; set; }

        public string Body { get; set; }

        public string Footer { get; set; }

        public override string ToString() =>
            new StringBuilder()
            .Append(Header)
            .Append(Body)
            .Append(Footer)
            .ToString();
    }
}

