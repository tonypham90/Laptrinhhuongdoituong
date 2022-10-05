// See https://aka.ms/new-console-template for more information

using Practice_OOP;

Console.WriteLine("Hello, World!");
// Triangle TamGiac = new Triangle();
// TamGiac.NhapTamGiac();
// TamGiac.Chuvi();
// DaGiac daGiac = new DaGiac();
// daGiac.NhapDaGiac();
// daGiac.Chuvi();
Phanso a = new Phanso();
Console.Write("Nhap tu so = ");
int tuso = Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap Mau so = ");
int mauso = Convert.ToInt32(Console.ReadLine());
a.tuso = tuso;
a.mauso = mauso;
a.mauso = 0;

    try
    {
        a.tuso = tuso;
        a.mauso = mauso;
        a.mauso = 0;

    }
    catch (Exception ex)
    {
        // Console.WriteLine("Ban da chia cho 0");
        Console.WriteLine(ex.Message);
    }
Console.WriteLine("xu ly tiep");
