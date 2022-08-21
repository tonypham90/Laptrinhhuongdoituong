namespace BaiTapOOP;

public class TamGiac
{
    public Diem A, B, C;

    public void NhapDinhTamGiac(string ghichu)
    {
        this.A = new Diem();
        this.A.nhap("Diem A");
        this.B = new Diem();
        this.B.nhap("Diem B");
        this.C = new Diem();
        this.C.nhap("Diem C");
    }

    public void Chuvitamgiac(string ghichu)
    {
        double chuvi = A.KhoanCach2diem(B) + B.KhoanCach2diem(C) + C.KhoanCach2diem(A);
        Console.WriteLine($"Chu vi tam giac la {chuvi.ToString("F")}");
    }
}