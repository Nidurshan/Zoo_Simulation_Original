namespace Zoo_Simulation
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter an Animal 1. Lion, 2. Elephant, 3. Tiger, 4. Bear: ");
            var selection = Console.ReadLine();

            if(selection == "Lion")
            {
                Animal lion = new Lion();
                lion.Intro();
                lion.SetDetails();
                lion.GetDetails();
            }
            else if(selection == "Elephant")
            {
                Animal elephant = new Elephant();
                elephant.Intro();
                elephant.SetDetails();
                elephant.GetDetails();
            }
            else if(selection == "Tiger")
            {
                Animal tiger = new Tiger();
                tiger.Intro();
                tiger.SetDetails();
                tiger.GetDetails();
            }
            else if(selection == "Bear")
            {
                Animal bear = new Bear();
                bear.Intro();
                bear.SetDetails();
                bear.GetDetails();
            }
            else
            {
                Console.WriteLine("Invalid Input!!");
            }
        }
    }

    public class Animal
    {
        public virtual string Name { get; set; }
        public virtual int Age { get; set; }
        public virtual string Food { get; set; }
        public virtual string MakeSound { get; set; }

        public Animal()
        {

        }

        public virtual void Intro() { }

        public virtual void SetDetails()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Sound: ");
            MakeSound = Console.ReadLine();
        }

        public virtual void GetDetails()
        {
            Console.WriteLine("Name:" + "\t" + Name);
            Console.WriteLine("Age:" + "\t" + Age);
            Console.WriteLine("Sound:" + "\t" + MakeSound);
        }
    }

    class Lion : Animal
    {
        public override string Name { get => base.Name; set => base.Name = value; }
        public override int Age { get => base.Age; set => base.Age = value; }
        public override string Food { get => base.Food; set => base.Food = value; }
        public override string MakeSound { get => base.MakeSound; set => base.MakeSound = value; }

        public Lion()
        {
        }

        public override void Intro()
        {
            Console.WriteLine("Enter Details for Lion");
        }

        public override void SetDetails()
        {
            base.SetDetails();
        }

        public override void GetDetails()
        {
            base.GetDetails();
        }
    }

    class Elephant : Animal
    {
        public override string Name { get => base.Name; set => base.Name = value; }
        public override int Age { get => base.Age; set => base.Age = value; }
        public override string Food { get => base.Food; set => base.Food = value; }
        public override string MakeSound { get => base.MakeSound; set => base.MakeSound = value; }

        public Elephant()
        {
        }

        public override void Intro()
        {
            Console.WriteLine("Enter Details for Elephant");
        }

        public override void SetDetails()
        {
            base.SetDetails();
        }

        public override void GetDetails()
        {
            base.GetDetails();
        }
    }

    public class Tiger : Animal
    {
        public override string Name { get => base.Name; set => base.Name = value; }
        public override int Age { get => base.Age; set => base.Age = value; }
        public override string Food { get => base.Food; set => base.Food = value; }
        public override string MakeSound { get => base.MakeSound; set => base.MakeSound = value; }

        public Tiger()
        {
        }

        public override void Intro()
        {
            Console.WriteLine("Enter Details for Tiger");
        }

        public override void SetDetails()
        {
            base.SetDetails();
        }

        public override void GetDetails()
        {
            base.GetDetails();
        }
    }

    public class Bear : Animal
    {
        public override string Name { get => base.Name; set => base.Name = value; }
        public override int Age { get => base.Age; set => base.Age = value; }
        public override string Food { get => base.Food; set => base.Food = value; }
        public override string MakeSound { get => base.MakeSound; set => base.MakeSound = value; }

        public Bear()
        {
        }

        public override void Intro()
        {
            Console.WriteLine("Enter Details for Bear");
        }

        public override void SetDetails()
        {
            base.SetDetails();
        }

        public override void GetDetails()
        {
            base.GetDetails();
        }
    }

    //interface ZooAnimal
    //{
    //    string Name { get; set; }
    //    int Age { get; set; }
    //    string Sound { get; set; }
    //}
}