namespace CuaHang.Entity;

public abstract class Item
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string IsDelete { get; set; }

    public virtual bool Tao()
    {
        throw new NotImplementedException();
    }

    public virtual bool Sua()
    {
        throw new NotImplementedException();
    }

    public virtual bool Xoa()
    {
        throw new NotImplementedException();
    }
    
}