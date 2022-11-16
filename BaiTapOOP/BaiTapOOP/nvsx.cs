namespace BaiTapOOP;

public class nvsx : Nhanvien
{
    
        public int sosp { get; set; }
        public int heso { get; set; }

        public void tinhluong()
        {
            this._luong = heso * sosp;
        }

        public void NhapNhanviensx(string ghichu)
        {
            NhapNhanvien(ghichu);
            Console.WriteLine("Nhap so san pham");
            this.sosp = int.Parse(Console.ReadLine());
        }

    
}