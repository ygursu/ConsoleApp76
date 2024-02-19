using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavyedenyasigirilenkisininehliyetkontr
{
    class Program
    {
        static void Main(string[] args)
        {

            //Klavyeden yaşı girilen kişinin ehliyet alıp alamayacağını gösteren C# programını yazınız.

            Console.WriteLine("Lütfen Yaşınızı Giriniz");
            int yas = Int32.Parse(Console.ReadLine());

            if (yas >= 18)
            {
                //Doğruysa ehliyet alabilirsiniz  
                Console.WriteLine("Ehliyet alabilirsiniz");
            }
            else
            {
                //Yanlışsa ehliyet alamazsınız
                Console.WriteLine("Ehliyet alamazsınız");
            }

            Console.ReadLine();


        }
    }
}