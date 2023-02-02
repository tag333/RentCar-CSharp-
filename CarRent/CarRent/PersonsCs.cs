
namespace CarRent
{
    public abstract class Person
    {
        public decimal Money { get; private set; }

        public string Name { get; set; }

        private int age;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value >= 18)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("U'r age under 18!");
                }
            }
        }

        public bool DriverLaw { get; set; }

        private string driverLawSustain;

        public string DriverLawSustain()
        {
            if (DriverLaw)
            {
                return "Okay";
            }
            return "No";
        }

        public static bool CheckPerson(Person person)
        {
            if (person.Name == "")
            {
                Console.WriteLine($"Username must be filled. Current moment: {person.Name}");
                return false;
            }
            if (person.Age < 18)
            {
                Console.WriteLine($"U'r age must be up 18 years. Current moment: {person.Age}");
                return false;
            }
            if (!person.DriverLaw)
            {
                Console.WriteLine($"U must have driver law. Current moment: {person.DriverLawSustain}");
                return false;
            }
            return true;
        }

        public static void OrderTheCar(Person person, bool Verif)
        {
            if (!Verif)
            {
                Console.WriteLine("U can't order the car!");
                return;
            }
            Console.WriteLine("Sucsess ordered the car");
        }

        public static void OpenAdminMenu(Person person)
        {
            if (person is Admin)
            {
                Console.WriteLine("Sucsess");
                return;
            }
            Console.WriteLine("Not enough rules");
        }

        public Person(string Name, int Age, bool DriverLaw)
        {
            this.Name = Name;
            this.Age = Age;
            this.DriverLaw = DriverLaw;
        }
    }

    public class Client : Person
    {
        public int CountOfOrderedCars { get; set; }

        public int Client_ID { get; private set; }

        public Client(int Client_ID, string Name, int Age, bool DriverLaw) : base(Name, Age, DriverLaw)
        {
            this.Client_ID = Client_ID;
        }
    }

    public class Admin : Person
    {
        public int Admin_ID { get; private set; }

        public Admin(int Admin_ID, string Name, int Age, bool DriverLaw) : base(Name, Age, DriverLaw) { }
    }
}

