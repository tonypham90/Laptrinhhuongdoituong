namespace BaiTapOOP;

public class DaGiac
{
    public Diem[] Nhomdiem;

    public void NhapDaGiac(string ghichu)
    {
        Console.WriteLine("Nhap Da giac toi thieu la 3 dinh");
        int sodinh;
        do
        {
            Console.WriteLine("So dinh da giac");
            sodinh = int.Parse(Console.ReadLine());
        } while (sodinh<3);
        
        this.Nhomdiem = new Diem[sodinh];
        for (int i = 0; i < sodinh; i++)
        {
            Diem current = new Diem();
            current.nhap($"Dinh thu {i+1}");
            this.Nhomdiem[i] = current;
        }
    }

    public void ChuviDagiac(string Ghichu)
    {
        
    }
}