using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = 100;
            int s2 = 25;
            int toplam = s1 + s2;
            Console.WriteLine(toplam);
            int s3 = 67;
            s3 = s3 + 1; // Tanımlı bir değişken olan s3'e tekrar kendisine 1 ekletir.
            s3 += 1; // += operatörü üstteki işlem ile aynıdır. Yani kendisine 1 ekletir.
            Console.WriteLine(s3);
            int fark = s1 - s2;
            int bolum = s1 / s2;
            int bolum2 = s1 / 4;
            int bolum3 = 80 / 4;
            int mod = 10 % 2;
            int mod2 = 15 % 6;
            Console.WriteLine(fark);
            Console.WriteLine(bolum);
            Console.WriteLine(bolum2);
            Console.WriteLine(bolum3);
            Console.WriteLine(mod);
            Console.WriteLine(mod2);
            int carpim = s1 * s2;
            Console.WriteLine(carpim);
            bool durum;
            durum = 4 > 1; // true
            Console.WriteLine(durum);
            durum = 4 < 1; // false
            Console.WriteLine(durum);
            durum = 3 <= 3; // true
            Console.WriteLine(durum);
            durum = 3 != 3; // false
            Console.WriteLine(durum);
            durum = durum == false; // En son durum false'ydi. Duruma göre kontrol edilir. False falseye eşit mi olur.
            Console.WriteLine(durum); // true olur.
            bool durum2 = 3 < 4 && 4 < 10 && 3 < 10; // true
            Console.WriteLine(durum2);
            bool durum3 = 3 < 5 && 3 < 1; // false
            Console.WriteLine(durum3);
            bool durum4 = 3 > 5 && 3 > 1; // false
            Console.WriteLine(durum4);
            bool durum5 = 3 != 3 && "negan" == "Negan"; // false
            Console.WriteLine(durum5);
            bool durum6 = 3 < 4 || 4 < 10; // true
            Console.WriteLine(durum6);
            bool durum7 = 3 < 5 || 3 < 1; // true
            Console.WriteLine(durum7);
            bool durum8 = 3 > 5 || 3 > 1; // true
            Console.WriteLine(durum8);
            bool durum9 = 3 != 3 || "negan" == "Negan"; // false
            Console.WriteLine(durum9);
            Console.ReadKey();
        }
    }
}
/* Değişkenler ve nesneler üzerinde işlemler yapmamızı sağlayan araçlara operatör denir.
   Toplama operatörü: +
   Çıkarma operatörü: -
   Bölme operatörü: /
   Çarpma operatörü: *
   Atama operatörü: =
   Mod alma operatörü: % (Bu işlem bölme işleminden kalan sonucu verir.)
   İki değeri karşılaştırmak için kullanılan, mantıksal cevap bildiren, tek başına ise bir işe yaramayan operatörlerdir.
   Büyüktür operatörü: >
   Küçüktür operatörü: <
   Büyük veya eşit mi operatörü: >=
   Küçük veya eşit mi operatörü: <=
   Eşit mi operatörü: ==
   Eşit değil mi operatörü: !=
   Birden fazla karşılaştırma operatörünü birleştirmek için kullanılan operatöler mantıksal operatörlerdir.
   Ve operatörü: && (İki karşılaştırmanın doğru olmasını ister.)
   Veya operatörü: || (İki karşılaştırmadan herhangi birinin doğru olmasını ister.)
*/