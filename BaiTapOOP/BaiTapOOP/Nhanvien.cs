namespace BaiTapOOP;

internal class Nhanvien
{
    public int Manv { get; set; }
    public string Ten { get; set; }
    public string Diachi { get; set; }
    public int cmnd { get; set; }
    public double luong { get; set; }

    public Nhanvien()
    {
        Console.WriteLine("Nhap ten");
        Random random = new Random();
        Manv = random.Next(1000, 9999);
        Ten = Console.ReadLine();
        Console.Write("Dia chi nha:");
        Diachi = Console.ReadLine();


    }
}

class NhanvienSX : Nhanvien
{
    public int sosp { get; set; }
    public int heso { get; set; }

    public void luongsx()
    {
        this.luong = heso * sosp;
    }
    
}

class NhanvienVP : Nhanvien
{
    public int sosp { get; set; }
    public int heso { get; set; }
}
