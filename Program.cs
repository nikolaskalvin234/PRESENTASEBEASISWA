using System;
namespace PresentaseBeasiswa

{
    class Program
    {
        static void Main(string[] args)
        {
            double spp                  = 8350000;
            double penghasilanOrangTua  = 0;
            int jumlahAnak              = 0;
            bool Prestasi               = false;
            bool diluarkota             = false;

            // Input penghasilan orang tua
            Console.Write("Masukkan penghasilan orang tua per bulan (Rp): ");
            penghasilanOrangTua = Convert.ToDouble(Console.ReadLine());

            // Input jumlah anak
            Console.Write("Masukkan jumlah anak dalam keluarga: ");
            jumlahAnak = Convert.ToInt16(Console.ReadLine());

            // Input apakah memiliki prestasi
            Console.Write("Apakah Anda memiliki prestasi (y/t): ");
            string inputPrestasi = Console.ReadLine();

            if (inputPrestasi.ToLower() == "y"){
                Prestasi = true;
            }

            // Menghitung tunjangan penghasilan (TP)
            double tunjanganPenghasilan = 0;
            if (penghasilanOrangTua > 5000000) {
                tunjanganPenghasilan = 0;
            }else if (penghasilanOrangTua >= 3000000 && penghasilanOrangTua <= 5000000){
                tunjanganPenghasilan = 600000;
            } else {
                tunjanganPenghasilan = 1500000;
            }

            // Menghitung tunjangan saudara (TS)
            double tunjanganSaudara = 0;

            if (jumlahAnak > 2){
                tunjanganSaudara = 1500000;
            }

            // Menghitung tunjangan juara (TJ)
            double tunjanganJuara = 0;
            if (Prestasi){
                Console.Write("Masukkan peringkat prestasi (1/2/3): ");
                int peringkatPrestasi = Convert.ToInt32(Console.ReadLine());

            switch (peringkatPrestasi){
                case 1:
                    tunjanganJuara = 2850000;
                    break;
                case 2:
                    tunjanganJuara = 1500000;
                    break;
                case 3:
                    tunjanganJuara = 1000000;
                    break;
            }
        }

        // Menghitung total bantuan
        double totalBantuan = tunjanganPenghasilan + tunjanganSaudara + tunjanganJuara;

        // Menghitung nilai persentase bantuan beasiswa
        double persentaseBantuan = (totalBantuan / spp) * 1.00;

        Console.WriteLine($"Total bantuan beasiswa: Rp {totalBantuan:N0}");
        Console.WriteLine($"Persentase bantuan beasiswa: {persentaseBantuan:N2}%");
        }
    }
}

