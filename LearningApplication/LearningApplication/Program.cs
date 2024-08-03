/* 1. Check for the voting eligibility*/

//Console.Write("Enter your age: ");
//int Age = Convert.ToInt32(Console.ReadLine());
//if (Age >= 18)
//    Console.WriteLine("You are eligible to vote");
//else
//    Console.WriteLine("You are not eligible to vote");

/* 2. hypotenus Calculator with random sides*/

//Random random = new Random();
//int BaseSide= random.Next(100);
//int AdjcentSide = random.Next(100);
//int Hyp = (int)Math.Sqrt(Math.Pow(BaseSide, 2) + Math.Pow(AdjcentSide, 2));
//Console.WriteLine($"The Hypotenous of the triangle is found to be : {Hyp}");
//Console.WriteLine($"To Be Accurate Hypotenous = {Math.Sqrt(Math.Pow(BaseSide, 2) + Math.Pow(AdjcentSide, 2))}");

/*3. Rank Calculation*/

//int Rank;
//Console.Write("Enter your Marks : ");
//if (Int32.TryParse(Console.ReadLine(), out Rank))
//{
//    if (Rank > 85)
//        Console.WriteLine("A Grade");
//    else if (Rank > 70 & Rank < 85)
//        Console.WriteLine("B Grade");
//    else if (Rank > 55 & Rank < 70)
//        Console.WriteLine("C Grade");
//    else if (Rank > 40 & Rank < 55)
//        Console.WriteLine("D Grade");
//    else
//        Console.WriteLine("Failed in the exam");
//}
//else
//    Console.WriteLine("Invalid Input has been fed to the System");

/*Switch Case and String*/

//Console.WriteLine("Please Enter you Details below : - ");
//Console.Write("Name : ");
//string? Name = Console.ReadLine();
//Console.Write("Completed Your Assignment  (Yes/No): ");
//string? Choice = Console.ReadLine();
//switch (Choice.ToLower())
//{
//    case "yes":
//        Console.WriteLine("Good");
//        break;
//    case "no":
//        Console.WriteLine("Try to do it ASAP");
//        break;
//    default:
//        Console.WriteLine("Please Enter a Valid input ! ! ! ! !");
//        break;
//}

/*Print Tables*/

//short Number;
//Console.Write("Enter a number within 25 : ");
//if(Int16.TryParse(Console.ReadLine(),out Number))
//{
//    for(int i = 1; i < 16; i++)
//    {
//        Console.WriteLine($"{Number} * {i} = {Number * i}");
//    }
//    Console.WriteLine("The Table can to an end");
//}

/* While Loop - Tables */

//short Number;
//Console.WriteLine("Enter a Number within 25 : ");
//if(Int16.TryParse(Console.ReadLine(),out Number))
//{
//    short Multiplier = 1;
//    while (Multiplier < 16)
//    {
//        Console.WriteLine($"{Number} * {Multiplier} = {Number * Multiplier}");
//        Multiplier++;
//    }
//}

/* Pattern Printing */

//Console.Write("Enter the number of Rows : ");
//short Row = Convert.ToInt16(Console.ReadLine());
//Console.Write("Enter the number of Columns : ");
//short Column = Convert.ToInt16(Console.ReadLine());
//Console.Write("Enter any Symbol : ");
//char Symbol = Console.ReadKey().KeyChar;
//Console.WriteLine("\n\n\n");
//for (int i = Row; i > 0; i--)
//{
//    for (int j = Column; j > 0; j--)
//    {
//        Console.Write($"\t{Symbol}");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("\n\n\nPattern Printed Successfully ! ! !");

/*Random Number Guessing*/

//Random random = new Random();
//short Number = (short)random.NextInt64(10);
//short Guess;
//while (Int16.TryParse(Console.ReadLine(),out Guess))
//{
//    if (Guess == Number)
//    {
//        Console.WriteLine("You Won");
//        break;
//    }
//    else if (Guess < Number)
//    {
//        Console.WriteLine("The Number is Larger");
//    }
//    else if (Guess < Number)
//    {
//        Console.WriteLine("The Number is Smaller");
//    }
//    else
//    {
//        Console.WriteLine("Try Again ! ! ! ! ! ! !");
//    }
//}

/* Creation of the Rock-Paper and SCissor Game*/

//Random random = new Random();
//int Chance;
//string[] options = { "Rock", "Paper", "Scissors" };
//short ChoiceInput;
//while(Int16.TryParse(Console.ReadLine(),out ChoiceInput))
//{
//    Chance = random.Next(0, 3);
//    if (ChoiceInput+1 == Chance)
//    {
//        Console.WriteLine("Success");
//        break;
//    }
//    else
//    {
//        Console.WriteLine($"Computer : {options[Chance]}\nHuman : {options[ChoiceInput]}");
//    }
//}

/*Arrays */

//String[] Cars = new string[3];
//Cars =["BMW","Audi","Benz"];
//foreach(string car in Cars)
//{
//    Console.WriteLine(car);
//}

/*Functions*/

//static void Multipy(int a,int b ,out int c)
//{
//    c = a * b;
//}

//int d;
//Multipy(2, 3, out d);
//Console.WriteLine(d);

/*Method Overloading*/

//using System;
//class Program
//{
//    static int add(int a ,int b)
//    {
//        return a + b;
//    }
//    static int add (int a , int b,int c)
//    {
//        return a + b + c;
//    }
//    static void Main(String[] args)
//    {
//        int a = 19;
//        int b = 34;
//        Console.WriteLine(add(a, b));
//        int c = 23;
//        Console.WriteLine(add(a, b, c));
//        return;
//    }
//}

/*Params */
//static int add(params int[] goods)
//{
//    int a=0;
//    foreach(int i in goods)
//    {
//        a += i;
//    }
//    return a;
//}

//Console.WriteLine(add(1, 2, 3));
//Console.WriteLine(add(1, 2, 3,4,5,6,7,8));

/*Exception handeling*/

//try
//{
//    short a = Convert.ToInt16(Console.ReadLine());
//    Console.WriteLine($"The entered Number os found to be : {a}");
//}
//catch (FormatException)
//{
//    Console.WriteLine("Please Enter only a valid integer");
//}
//Console.WriteLine("This Line Should Be Printed at any cause");

/*Conditional Operator*/

//String Message = (Convert.ToInt16(Console.ReadLine()) > 4) ? "The is true" : "This is false";
//Console.WriteLine(Message);

/*String Interpolation -> using $ Symbol to insert the variable directly into the string*/

/* 2d Arrays - Implement a 3x3 parking lot via 2d array and car names as values*/

//string[,] Parking = { { "Ford", "GT", "Wagon" }, { "Daron", "Denver", "Tesla" }, { "Fing", "Harrier", "Navigator" } };

//Parking[0, 2] = "GT-Cobra";
//foreach(string f in Parking)
//{
//    Console.WriteLine(f);
//}

/* Classes */

//using System;

//namespace LearningApplication
//{
//    class Student
//    {
//        public int id;
//        public string name;
//        public Student(int id,string name)
//        {
//            this.id = id;
//            this.name = name;
//        }
//        public void Printer()
//        {
//            Console.WriteLine($"\n\tName : {this.name}\n\tId : {this.id}");
//        }
//    }

//    //Declaration of the driver Class
//    class Program
//    {
//        public static void Main(String[] args)
//        {
//            Student S1 = new Student(12, "Sam");
//            Student S2 = new Student(11, "Denise");
//            Student[] Students = { S1, S2 };
//            foreach(Student student in Students)
//            {
//                student.Printer();
//            }
//        }
//    }
//}

/* Inheritance */

//using System;
//using System.Net.Http.Headers;

//namespace LearningApplication
//{
//    class Vechile
//    {
//        public int VechileNumber;

//    }

//    class Car : Vechile
//    {
//        public Car(int Vechile_Number)
//        {
//            base.VechileNumber = Vechile_Number;
//        }
//    }
//    class Truck : Vechile
//    {
//        public Truck(int Vechile_Number)
//        {
//            base.VechileNumber = Vechile_Number;
//        }
//    }

//    // Declaration of the Driver Class
//    class Program
//    {
//        public static void Main(String[] args)
//        {
//            Car C1 = new Car(21);
//            Truck T1 = new Truck(31);
//            Console.WriteLine(C1.VechileNumber);
//            Console.WriteLine(T1.VechileNumber);
//            return;

//        }
//    }
//}

/* Abstract Classes */

//using System;
//using System.Net.Http.Headers;

//namespace LearningApplication
//{
//    abstract class Vechile
//    {
//        public int VechileNumber;

//    }

//    class Car : Vechile
//    {
//        public Car(int Vechile_Number)
//        {
//            base.VechileNumber = Vechile_Number;
//        }

//    }
//    class Truck : Vechile
//    {
//        public Truck(int Vechile_Number)
//        {
//            base.VechileNumber = Vechile_Number;
//        }
//    }

//    // Declaration of the Driver Class
//    class Program
//    {
//        public static void Main(String[] args)
//        {
//            Car C1 = new Car(21);
//            Vechile T1 = new Truck(31);
//            Console.WriteLine(C1.VechileNumber);
//            Console.WriteLine(T1.VechileNumber);
//            return;

//        }
//    }
//}

/* Getter And Setter Auti implemented Properties */

//using System;

//namespace LearningApplication
//{
//    public class Car
//    {
//        int Speed;
//        float Milage;
//        public string Model { get; set; }
//        public Car(int Speed,float Milage,String Model)
//        {
//            this.Speed = Speed;
//            this.Milage = Milage;
//            this.Model = Model;
//        }
//        public int _Speed
//        {
//            get { return this.Speed; }
//            set {this.Speed = (value < 500) ? value : 500;}
//        }
//    }

//    public class Program
//    {
//        public static void Main(String[] Args)
//        {
//            Car c1 = new Car(150, 12.5f, "Thar");
//            c1._Speed = 1253;
//            Console.WriteLine(c1._Speed);
//            Console.WriteLine(c1.Model);
//        }
//    }
//}

/*Enum*/

//using System;
//enum Week{ Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday }
//class Program
//{
//    public static void Main(String[] arg)
//    {
//        Console.WriteLine($"{Week.Friday} Which is a {Week.Friday.GetType()} Datatype is the {(int)Week.Friday+1} Member.");

//    }
//}

/* GEnerics */

//using System;
//namespace LearningApplication
//{

//    public class Program
//    {
//        public static void Printer<Thing>(Thing[] array)
//        {
//            foreach(Thing i in array)
//            {
//                Console.WriteLine(i);
//            }
//            Console.WriteLine("Action Completed \n\n\n");
//        }
//        public static void Main(String[] args)
//        {
//            int[] IntegerArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//            float[] FloatArray = { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f, 6.6f, 7.7f, 8.8f, 9.9f };
//            char[] CharaterArray = { 'a', 'b', 'c', 'l', 'k', 't', 'e' };
//            String[] StringArray = { "Dog", "Cat", "Fish", "Giraffe", "Zebra" };
//            Printer(IntegerArray);
//            Printer(FloatArray);
//            Printer(CharaterArray);
//            Printer(StringArray);
//        }
//    }
//}

/* Multithreading */

//using System;
//using System.Reflection;
//using System.Threading;

//namespace LearningApplication
//{
//    public class Program
//    {
//        public static void CounterUp()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine($"From Counter 1 : {i + 1}");
//                Thread.Sleep(600);
//            }

//        }
//        public static void CounterDown()
//        {
//            for (int i = 10; i > 0; i--)
//            {
//                Console.WriteLine($"From Counter 2 : {i}");
//                Thread.Sleep(600);
//            }

//        }
//        public static void Main(String[] args)
//        {
//            Thread MainThread = Thread.CurrentThread;
//            MainThread.Name = "My Main THread";

//            Thread CounterUpThread = new Thread(CounterUp);
//            Thread CounterDownThread = new Thread(CounterDown);
//            CounterUpThread.Start();
//            CounterDownThread.Start();
//            Console.WriteLine($"\n\n\n\n{MainThread.Name} Execution Completed ! ! ! !");
//        }
//    }
//}

/*Parameterized Multithreading*/


using System;
using System.Reflection;
using System.Threading;

namespace LearningApplication
{
    public class Program
    {
        public static void CounterUp(String Name)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"From {Name}: {i + 1}");
                Thread.Sleep(600);
            }

        }
        public static void CounterDown(String Name)
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"From {Name} : {i}");
                Thread.Sleep(600);
            }

        }
        public static void Main(String[] args)
        {
            Thread MainThread = Thread.CurrentThread;
            MainThread.Name = "My Main THread";

            Thread CounterUpThread = new Thread(()=>CounterUp("Sam"));
            Thread CounterDownThread = new Thread(()=>CounterDown("Fang"));
            CounterUpThread.Start();
            CounterDownThread.Start();
            Console.WriteLine($"\n\n\n\n{MainThread.Name} Execution Completed ! ! ! !");
        }
    }
}