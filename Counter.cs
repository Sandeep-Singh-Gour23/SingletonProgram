using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonProgram
{
    sealed class Counter
    {
        private static int test = 0;
        static int count = 0;
        private static Counter instance = null;
        private Counter() {
            test++;
            Console.WriteLine("test value:" + test);    
        }

        public static Counter getInstance
        {
           get { 
               if (instance == null)
                    instance = new Counter();
               return instance;
            }
        }

        public void Increment()
        {
            count=count+1;
        }
        public void Decrement()
        {
            count=count-1;
        }
        public void CurrentCount()
        {
            Console.WriteLine("Current Count is" + count);
        }

    }
}
