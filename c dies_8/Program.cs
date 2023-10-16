using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace c_dies_8
{
    internal class Program
    {
        public delegate void Message2(string arg);
        static event Message2 Notify;
        public static int cash;
       // static void Output(string message)=>Console.WriteLine(message);

        static void Main(string[] args)
        {
            /*Notify += Output;
            if (cash > 0)
            {
                Notify("I see you");
            }*/
            People p = new People(20);
            //p.PropertyChanged += p.Output;
            p.Age = 21;
            p.Age = 51;

            //  КОЛЛЕКЦИИ

            List<string> names = new List<string>(4);    // std::vector<T>  c++
            LinkedList<string>namesLink=new LinkedList<string>();   // двусвязный список
            Queue<string>people=new Queue<string>(); 
            Stack<string> people2=new Stack<string>();
            Dictionary<int,string>people3= new Dictionary<int,string>();
            SortedList<int,string>people4=new SortedList<int,string>();


            stdvector<int> vec=new stdvector<int>();
            vec.AddLast(33);
            vec.AddLast(44);
            vec.AddLast(55);
            vec.Print();
            Console.WriteLine();
            vec.AddFirst(1);
            vec.AddFirst(7);
            vec.AddFirst(77);
            vec.Print();
            //vec.Remove(2);
            //vec.Print();


            /* Message2 mes = delegate ()
             {
                 Console.WriteLine("Bbbbbbb");
             };
             Message2 hello = () =>
             {
                 Console.WriteLine("Hello");
             };
             //Message mes = Hello;
             //mes();*/
        }
        public class Vector3<T>
        {
            public T ger(T x) => x;
        }

        public bool ger1<T,Y>(T x,Y y)
        {
           // if (x.GetType == y.GetType)
                return x.GetType == y.GetType ? true : false ;
        }
        public bool F1<T>(T x, T y) where T:IComparable<T>
        {
            return (x.CompareTo(y) > 0);
        }

        static void Hello() => Console.WriteLine("Bbbbbbb");
        public class People
        {
            private int age { get; set; }
            public People(int age) {
                PropertyChanged += Output;
                this.age = age; }
            public int Age { get { return age; } set { if (age != value) { age = value; OnAgeChange(); } } }
            public event PropertyEventHandler PropertyChanged;
            public void Output(People sender, int age) => Console.WriteLine($" теперь возраст равен :  {age}");
            protected virtual void OnAgeChange()
            {
                PropertyEventHandler handler = PropertyChanged;
                handler?.Invoke(this, age);
            }
        }
      
        public delegate void PropertyEventHandler
            (People sender, int Age);
        

       /* interface IPropertyChange
        {
            event PropertyEventHandler PropertyChanged;
        }*/

    }
}