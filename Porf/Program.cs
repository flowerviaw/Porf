using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
ImageProcessor imageProcessor = new ImageProcessor();

imageProcessor.Resize(-10);
imageProcessor.Resize(50);
imageProcessor.Resize(20);
imageProcessor.Resize(200);
imageProcessor.Resize(200, 300);
imageProcessor.Resize("A4");


class ImageProcessor
{
    public void Resize(int persen)
    {
        if (persen <= 0)
        {
            Console.WriteLine("Error! Presentase tidak boleh nol atau negatif !!");
        }
        else if (persen < 100)
        {
            Console.WriteLine($"Mengecilkan gambar sebesar {persen}%");
        }
        else if (persen > 100)
        {
            Console.WriteLine($"Memperbesar gambar sebesar {persen}");
        }
        else
        {
            Console.WriteLine($"Ukuran tetap (100%)! Tidak berubah");
        }
    }

    public void Resize(int lebar, int tinggi)
    {
        Console.WriteLine($"Mengubah ukuran gambar menjadi {lebar} px X {tinggi} px ");
    }

    public void Resize(string ukurankertas)
    {
        Console.WriteLine($"Menyesuaikan ke format kertas {ukurankertas}");
    }
}
