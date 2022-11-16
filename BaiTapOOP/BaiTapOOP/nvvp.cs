namespace BaiTapOOP;

public class nvvp
{
    class NhanvienVP : Nhanvien
    {
        public int sosp { get; set; }
        public int heso { get; set; }

        public NhanvienVP()
        {
            Console.WriteLine("Nhap ghi chu");
            var text = Console.ReadLine();
            base.NhapNhanvien(text);

        }
    }
}