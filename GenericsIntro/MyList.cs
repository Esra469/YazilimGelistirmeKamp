using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0]; //void içinde hangi type vermişsem odur.
        }
        public void Add(T item)
        {
            T[] tempArray = items;//stack de geçici olarak tutması için atadık. yoksa yeni adres ekleyip kaybolur.
            items = new T[items.Length + 1];
            
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                    
            }
            items[items.Length-1] = item;

        }
    }
}
