using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tugasnya_ady;

namespace tugasnya_ady
{
    /* membuat superclass laptop */
    class Laptop
    {
        public string merk, tipe;
        public Vga vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} dinyalakan");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} dimatikan");
        }
    }

    /* membuat class ASUS sebagai anakan dari class laptop */
    class ASUS : Laptop
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }
    }

    /* membuat 2 anakan class dari class ASUS */
    class ROG : ASUS
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }

    class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    /* membuat class ACER sebagai anakan dari class laptop */
    class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }

    /* membuat 2 anakan class dari class ACER */
    class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }

    class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }

    /* membuat class Lenovo sebagai anakan dari class laptop */
    class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }
    /* membuat 2 anakan class dari class Lenovo */
    class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.tipe = "IdeaPad";
        }
    }

    class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }
    /* membuat superclass VGA */
    class Vga
    {
        public string merk;
    }

    /* membuat s2 anak class dari class Vga */
    class Nvidia : Vga
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }

    class AMD : Vga
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }


    /* membuat superclass processor */
    class Processor
    {
        public string merk, tipe;
    }

    /* membuat class intel sebagai class anak dari processor */
    class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }
    /* membuat 3 anakan dari class intel */

    class CoreI3 : Intel
    {
        public CoreI3()
        {
            base.tipe = "Core i3";
        }
    }

    class CoreI5 : Intel
    {
        public CoreI5()
        {
            base.tipe = "Core i5";
        }
    }

    class CoreI7 : Intel
    {
        public CoreI7()
        {
            base.tipe = "Core i7";
        }
    }

    /* membuat class amd sebagai anakan dari class processor */
    class amd : Processor
    {
        public amd()
        {
            base.merk = "AMD";
        }
    }

    /* membuat 2 anakan dari class amd */
    class Ryzen : amd
    {
        public Ryzen()
        {
            base.tipe = "RAYZEN";
        }
    }

    class Athlon : amd
    {
        public Athlon()
        {
            base.tipe = "ATHLON";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook();
            laptop1.vga = new Nvidia();
            laptop1.processor = new CoreI5();
            Console.WriteLine($"Merk VGA : {laptop1.vga.merk}");
            Console.WriteLine($"Merk Processor : {laptop1.processor.merk}");
            Console.WriteLine($"Tipe Processor : {laptop1.processor.tipe}");
            /*  bagian yang di comment disini adalah jawaban dari soal no.2 yang ketika dijalankan akan terjadi eror
                laptop1.Ngoding();  
            */

            Laptop laptop2 = new IdeaPad();
            laptop2.vga = new AMD();
            laptop2.processor = new Ryzen();
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            Predator predator = new Predator();
            predator.vga = new AMD();
            predator.processor = new CoreI7();
            predator.BermainGame();

            /*  Bagian yang di comment disini adalah jawaban dari soal no.5, yang ketika dijalankan akan terjadi eror   
                ACER acer = new Predator();  
                acer.BermainGame();   
            */
        }
    }
}

