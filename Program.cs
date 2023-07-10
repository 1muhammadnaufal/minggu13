using System;
using System.Collections.Generic;

namespace pemrog13
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "2989";
            mhs1.namaMahasiswa = "samsudin";

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "2868";
            mhs2.namaMahasiswa = "martin";

            List<Mahasiswa> list = new List<Mahasiswa>();
            list.Add(mhs1);
            list.Add(mhs2);


            Console.WriteLine("NIM      NAMA");
            Console.WriteLine("=================");
            foreach (Mahasiswa mhs in list)
            {
                Console.WriteLine("{0},    {1}", mhs.Nim, mhs.namaMahasiswa);
            }

            Console.ReadKey();

        }
    }
}
