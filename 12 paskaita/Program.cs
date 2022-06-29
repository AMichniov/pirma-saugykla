namespace _12_paskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sukurti abstrakčia klasę Person, su dviem laukais: name, surname.

            //Sukurti abstraktų metodą: PrintInfo();

            //Sukurti klases Student, Lecturer, kurios paveldi "Person" klasę.
            //Student ir Lecturer klasėse praplėskite min. 2 papildomais laukais.
            //Student ir Lecturer klasėse implementuokite PrintInfo() metodą

            //Main metode sukurti Student ir Lecturer objektų ir iškviesti PrintInfo() metodą.

            var studen = new Student("Jonas", "Jonaitis", 25, 145789);
            var lecturer = new Lecturer("Petras", "Petraitis", 1981, 2589);

            studen.PrintInfo();
            lecturer.PrintInfo();

            Info(studen);
        }
        // priima studet ir lecturer nes jie paveldi is person klases todel ok
        static void Info(Person person) 
        {
            person.PrintInfo();
        }
    }
}
