namespace QLCH.Entity;

public struct LoaiHang
{
    public string name { get; set; }
    public bool IsDelete { get; set; }

    public LoaiHang(string name)
    {
        this.name = name;
        IsDelete = false;
    }

    public void Remove()
    {
        IsDelete = true;
    }
}