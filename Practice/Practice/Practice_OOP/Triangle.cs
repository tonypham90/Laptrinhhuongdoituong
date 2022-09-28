namespace Practice_OOP;

public class Triangle
{
    private Diem A;
    private Diem B;
    private Diem C;

    public void Chuvi()
    {
        Console.Write("Chu vi tam giac la");
        var Chuvi = A.SpacingFromCurrentNode(B) + B.SpacingFromCurrentNode(C) + C.SpacingFromCurrentNode(A);
        Console.WriteLine(Chuvi);
    }

    public void NhapTamGiac()
    {
        Diem a = new Diem();
        a.Nhap("Nhap Diem A");
        A = a;
        Diem b = new Diem();
        Diem c = new Diem();
        b.Nhap("Nhap Diem B");
        c.Nhap("Nhap Diem C");
        B = b;
        C = c;
    }
}