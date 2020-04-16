using System;

namespace lektia1604
{
    class MyList<T>
    {
        T [] arr;
        public MyList()
        {
            arr = new T [0];
        }
        public void add(T a)
        {
            T [] tmp = new T [arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                tmp[i] = arr[i];
            }

            tmp[arr.Length] = a;
            arr = tmp;
        }

        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        /* public T this[int index]
        {
            get{return arr[index];}
        } */

        public string this[string index]
        {
            get{ return index ;}
        }

        public int Count()
        {
            return arr.Length;
        }

        public void Clear()
        {
            arr = new T[0];
        }
    }

    class carCollection<T>
    {
       MyList<string> carName;
       MyList<DateTime> yearCar ;

       public carCollection()
       {
           carName = new MyList<string>();
           yearCar = new MyList<DateTime>();

       }

       public string this[string index]
       {
           get{return carName + " " + index;}
       }

       public void addCar(string name , DateTime year)
       {
           carName.add(name);
           yearCar.add(year);
       }
    }

    class Program
    {
        static void Main(string[] args)
        {
             MyList <int> myList = new MyList <int> ();
            myList.add(5);
            myList.add(7);
           // int b = myList[0];
            //System.Console.WriteLine(b);
            myList.Print();
            System.Console.WriteLine(myList.Count());
            myList.Clear();
            System.Console.WriteLine(myList.Count());
            myList.add(12);
            myList.add(124);
            System.Console.WriteLine(myList.Count());

            MyList <string> myListStr = new MyList<string>();
            myListStr.add("A");
            myListStr.add("B");
            //string str = myListStr[0];
            System.Console.WriteLine(myListStr["world"] + " " + myListStr["Game"]);
            myListStr.Print(); 
        }
    }
}
