namespace BaiTapOOP;

public class LopPhanSo
{
    private int Tuso { get; set; }
    private int Mauso { get; set; }

    public void InputValue(string ghichu)
    {
        Console.WriteLine(ghichu);
        Console.Write("Tuso: ");
        this.Tuso = int.Parse(Console.ReadLine());
        Console.Write("MauSo:");
        this.Mauso = int.Parse(Console.ReadLine());
    }

    public int tuso
    {
        get => this.Tuso;
        set
        {
            if (value!=0)
            {
                this.Tuso = value;
            }
        }
    }

    public int mauso
    {
        get => this.Mauso;
        set
        {
            if (value!=0)
            {
                this.Mauso = value;
            }
            else
            {
                Exception ex = new Exception("Ban da gan mau so bang 0");
                throw ex;
            }
        }
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