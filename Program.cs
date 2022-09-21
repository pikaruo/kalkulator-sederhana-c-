public class Program
{
    static void Main()
    {
    pilih:
        Console.WriteLine("========================");
        Console.WriteLine("1. Penjumalahan");
        Console.WriteLine("2. Pengurangan");
        Console.WriteLine("3. Perkalian");
        Console.WriteLine("4. Pembagian");
        Console.WriteLine("X. Keluar");
        Console.WriteLine("========================\n");
        Console.Write("Masukkan angka 1 - 4 : ");
        string pilih = Console.ReadLine();

        if (pilih == "1")
        {
            Console.Write("Masukkan Angka Pertama : ");
            int angka1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Angka Kedua : ");
            int angka2 = Convert.ToInt32(Console.ReadLine());
            Penjumalahan(angka1, angka2);
        }
        else if (pilih == "2")
        {
            Console.Write("Masukkan Angka Pertama : ");
            int angka1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Angka Kedua : ");
            int angka2 = Convert.ToInt32(Console.ReadLine());
            Pengurangan(angka1, angka2);
        }
        else if (pilih == "3")
        {
            Console.Write("Masukkan Angka Pertama : ");
            int angka1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Angka Kedua : ");
            int angka2 = Convert.ToInt32(Console.ReadLine());
            Perkalian(angka1, angka2);
        }
        else if (pilih == "4")
        {
            Console.Write("Masukkan Angka Pertama : ");
            int angka1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Angka Kedua : ");
            int angka2 = Convert.ToInt32(Console.ReadLine());
            Pembagian(angka1, angka2);
        }
        else if (pilih == "X" || pilih == "x")
        {
            Console.WriteLine("Terimakasih");
        }
        else
        {
            Console.WriteLine("Pilihan Tidak Ada!");
            goto pilih;
        }

        Console.WriteLine("========================");
        Console.WriteLine("Ingin Menghitung Lagi ? [Y/N] ?");
        string lanjut = Console.ReadLine();
        if (lanjut == "Y" || lanjut == "y")
        {
            goto pilih;
        }
        else
        {
            Console.WriteLine("Terimakasih");
        }
    }

    static void Penjumalahan(int angka1, int angka2)
    {
        Console.Write("Hasil Perhitungan : ");
        Console.WriteLine(angka1 + angka2);
    }

    static void Pengurangan(int angka1, int angka2)
    {
        Console.Write("Hasil Perhitungan : ");
        Console.WriteLine(angka1 - angka2);

    }

    static void Perkalian(int angka1, int angka2)
    {
        Console.Write("Hasil Perhitungan : ");
        Console.WriteLine(angka1 * angka2);

    }

    static void Pembagian(int angka1, int angka2)
    {
        Console.Write("Hasil Perhitungan : ");
        Console.WriteLine(angka1 / angka2);

    }
}

