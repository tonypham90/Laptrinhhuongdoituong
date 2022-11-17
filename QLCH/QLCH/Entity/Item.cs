using Microsoft.AspNetCore.Mvc;
using QLCH.Operation;

namespace QLCH.Entity;

public class Item :IList
{
    private IList _ruleImplementation;
    protected string Id { get; set; }
    protected string Name { get; set; }
    protected string Label { get; set; }
    protected string Manuf
    {
        get;
        set;
    }
    protected int Qty
    {
        get;
        set;
    }
    protected float Price
    {
        get;
        set;
    }
    protected string Exp { get; set; }
    protected string Mfg { get; set; }

    public void Input()
    {
        throw new NotImplementedException();
    }

    public void Add()
    {
        throw new NotImplementedException();
    }

    public void Remove(string ID)
    {
        throw new NotImplementedException();
    }

    public void Remove()
    {
        throw new NotImplementedException();
    }

    public void Create()
    {
        throw new NotImplementedException();
    }
    
    public void Update(string Findvalue)
    {
        throw new NotImplementedException();
    }
}