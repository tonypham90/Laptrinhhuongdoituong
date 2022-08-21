namespace BaiTapOOP;

public class Diem
{
    public int x;
    public int y;

    public void nhap(string ghichu)
    {
        Console.WriteLine($"Nhap Toa do X diem{ghichu}");
        this.x = int.Parse(Console.ReadLine());
        Console.WriteLine($"Nhap Toa do Y diem{ghichu}");
        this.y = int.Parse(Console.ReadLine());
    }

    public double KhoanCach2diem(Diem other)
    {
        double spacing = Math.Sqrt(Math.Pow(this.x - other.x,2) + Math.Pow(this.y - other.y, 2));
        return spacing;
    }
    
}