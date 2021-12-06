using System;
using System.Collections.Generic;

namespace w13praktikumnyimpendata
{
    class Data
    {
        public int Nim { get; set; }
        public string Nama { get; set; }
        public string JenisKelamin { get; set; }
        public int TahunMasuk { get; set; }
        public string ProgramStudi { get; set; }
        public string Kelas { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berapa data : ");
            int data = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i=0; i<data; i++)
            {
                Console.WriteLine($"data ke-{i}");
                List<Data> listData = new List<Data>()
                {
                    new Data()
                    {
                        Nim = Convert.ToInt32(Console.ReadLine()),
                        Nama = Convert.ToString(Console.ReadLine()),
                        JenisKelamin = Convert.ToString(Console.ReadLine()),
                        TahunMasuk = Convert.ToInt32(Console.ReadLine()),
                        ProgramStudi = Convert.ToString(Console.ReadLine()),
                        Kelas = Convert.ToString(Console.ReadLine()),

                    }, };
                }
            }
        }
    }

