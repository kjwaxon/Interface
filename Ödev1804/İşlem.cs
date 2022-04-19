using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev1804
{
    public interface İşlem
    {
        void toplama(int a,int b);
        void çarpma(int a,int b);

    }
      
    class X : İşlem
    {
        int n, m;
       public void toplama(int a, int b)
        {
            n = a + b;
            Console.WriteLine("2 sayının toplamı : "+n);
        }
                public void çarpma(int a, int b)
        {
            m = a * b;
            Console.WriteLine("2 sayının çarpımı : "+ m);
        }

    }
}
