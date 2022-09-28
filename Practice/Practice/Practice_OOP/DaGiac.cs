namespace Practice_OOP;

public class DaGiac
{
    private Diem[] Danhsachdinh;

    public void NhapDaGiac()
    {
       
        Console.Write("So Dinh Da Giac");
        int NoofNode = Convert.ToInt32(Console.ReadLine());
        var ListofNode = new Diem[NoofNode];
        for (int i = 0; i < ListofNode.Length; i++)
        {
            Diem Node = new Diem();
            Node.Nhap($"Nhap Dinh thu {i + 1}");
            ListofNode[i] = Node;
        }

        Danhsachdinh = ListofNode;
    }

    public void Chuvi()
    {
        Console.WriteLine("Chu vi da giac");
        var Chuvi = 0.0;
        for (int i = 0; i < Danhsachdinh.Length; i++)
        {
            if (i == Danhsachdinh.Length-1)
            {
                Chuvi += Danhsachdinh[i].SpacingFromCurrentNode(Danhsachdinh[0]);
            }

            else
            {
                Chuvi += Danhsachdinh[i].SpacingFromCurrentNode(Danhsachdinh[1+i]);
            }
        }
        Console.WriteLine($"Chu vi da giac = {Chuvi}");
    }
}
