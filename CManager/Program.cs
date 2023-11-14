using System;
using System.Collections.Generic;

namespace Cmaganger
{
    class Program
    {
        static List<string> data = new List<string>();

        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Pilih operasi CRUD:");
                Console.WriteLine("1. Tambah data");
                Console.WriteLine("2. Tampilkan data");
                Console.WriteLine("3. Edit data");
                Console.WriteLine("4. Hapus data");
                Console.WriteLine("5. Keluar");
                Console.Write("Pilihan: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            TambahData();
                            break;
                        case 2:
                            TampilkanData();
                            break;
                        case 3:
                            EditData();
                            break;
                        case 4:
                            HapusData();
                            break;
                        case 5:
                            isRunning = false;
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak valid!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Masukan tidak valid!");
                }

                Console.WriteLine();
            }
        }

        static void TambahData()
        {
            Console.Write("Masukkan data: ");
            string newData = Console.ReadLine();
            data.Add(newData);
            Console.WriteLine("Data berhasil ditambahkan.");
        }

        static void TampilkanData()
        {
            Console.WriteLine("Data saat ini:");
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        static void EditData()
        {
            Console.Write("Masukkan indeks data yang ingin diubah: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                if (index >= 0 && index < data.Count)
                {
                    Console.Write("Masukkan data baru: ");
                    string newData = Console.ReadLine();
                    data[index] = newData;
                    Console.WriteLine("Data berhasil diubah.");
                }
                else
                {
                    Console.WriteLine("Indeks tidak valid!");
                }
            }
            else
            {
                Console.WriteLine("Masukan tidak valid!");
            }
        }

        static void HapusData()
        {
            Console.Write("Masukkan indeks data yang ingin dihapus: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                if (index >= 0 && index < data.Count)
                {
                    data.RemoveAt(index);
                    Console.WriteLine("Data berhasil dihapus.");
                }
                else
                {
                    Console.WriteLine("Indeks tidak valid!");
                }
            }
            else
            {
                Console.WriteLine("Masukan tidak valid!");
            }
        }
    }
}
