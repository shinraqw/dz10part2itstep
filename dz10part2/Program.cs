namespace dz10part2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Oceanarium<Animal> oceanarium = new Oceanarium<Animal>();
            Console.Write("Enter number of animal: ");
            int NumberAnimal = int.Parse(Console.ReadLine());
            for (int i = 0; i < NumberAnimal; i++)
            {
                Console.Write("\nEnter name : ");
                string name = Console.ReadLine();

                Console.Write("Enter type : ");
                string type = Console.ReadLine();

                Console.Write("Enter year : ");
                int year = int.Parse(Console.ReadLine());

                Animal animal = new Animal { Name = name, Type = type, Year = year };
                oceanarium.Animals.Add(animal);
            }
            foreach (var animal in oceanarium.Animals)
            {
                animal.Show();
            }




            Team<Footballer> team = new Team<Footballer>();
            for (int i = 0; i < 11; i++)
            {
                Console.Write("Enter name of footballer: ");
                string name = Console.ReadLine();

                Console.Write("Enter number : ");
                int number = int.Parse(Console.ReadLine());

                Footballer footballer = new Footballer { Name = name, Number = number };
                team.Footballers.Add(footballer);
            }
            foreach (var player in team.Footballers)
            {
                player.Show();
            }

            Cafe<Employee> cafe = new Cafe<Employee>();
            Console.Write("Enter number of emloyers: ");
            int NumberEmployee = int.Parse(Console.ReadLine());
            for (int i = 0; i < NumberEmployee; i++)
            {
                Console.Write("\nEnter name : ");
                string name = Console.ReadLine();

                Console.Write("Enter type work : ");
                string work = Console.ReadLine();

                Employee employee = new Employee { Name = name, Work = work };
                cafe.Workers.Add(employee);
            }
            foreach (var worker in cafe.Workers)
            {
                worker.Show();
            }


        }
    }
}