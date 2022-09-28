namespace Practice_OOP;

public class Diem
{
    public int X;
    public int Y;

    public void Nhap(string Ghichu)
    {
        Console.WriteLine(Ghichu);
        Console.Write("Nhap Toa do x:");
        this.X = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap Toa do y:");
        Y = int.Parse(Console.ReadLine());
    }

    public double SpacingFromCurrentNode(Diem otherNode)
    {
        return Math.Sqrt((this.X - otherNode.X) * (this.X - otherNode.X) + (this.Y - otherNode.Y) * (this.Y - otherNode.Y));
    }
    
}