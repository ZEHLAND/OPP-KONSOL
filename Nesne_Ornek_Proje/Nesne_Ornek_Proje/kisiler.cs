using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_Ornek_Proje
{
    class kisiler
    {
        public void kisiListesi()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + ".kisi");
            }
        }
        public void kisi(string adSoyad)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(adSoyad);
            }
        }
    }
}
