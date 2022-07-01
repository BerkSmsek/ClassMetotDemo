using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public  void  Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi : "+ musteri.İsim);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi : " + musteri.İsim);
        }
        public void Liste(Musteri musteri)
        {
            Console.WriteLine("Musteri listelendi : " + musteri.İsim);
        }
    }
}
