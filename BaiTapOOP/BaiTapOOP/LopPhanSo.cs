namespace BaiTapOOP;

public class LopPhanSo
{
    public int Tuso,Mauso;

    public void InputValue(string ghichu)
    {
        Console.WriteLine(ghichu);
        Console.Write("Tuso: ");
        this.Tuso = int.Parse(Console.ReadLine());
        Console.Write("MauSo:");
        this.Mauso = int.Parse(Console.ReadLine());
    }

    public LopPhanSo Sum(LopPhanSo phanSo)
    {
        Console.WriteLine($"Tong phan so {this.Tuso}/{this.Mauso} va {phanSo.Tuso}/{phanSo.Mauso}");
        LopPhanSo result = new LopPhanSo();
        result.Tuso = phanSo.Tuso * this.Mauso + phanSo.Mauso * this.Tuso;
        result.Mauso = phanSo.Mauso * this.Mauso;
        return result;
    }
}