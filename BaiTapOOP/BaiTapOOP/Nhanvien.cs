namespace BaiTapOOP;

public class Nhanvien
{
    protected int Manv { get; set; }
    public string Ten { get; set; }
    public string Diachi { get; set; }
    public int cmnd { get; set; }
    protected double _luong;

    public void NhapNhanvien(string ghichu)
    {
        Console.WriteLine(ghichu);
        Console.WriteLine("Nhap ten");
        Random random = new Random();
        Manv = random.Next(1000, 9999);
        // Ten = Console.ReadLine();
        Console.Write("Dia chi nha:");
        Diachi = Console.ReadLine();


    }
}
