using System.Reflection.Emit;
using Microsoft.AspNetCore.Mvc;
using QLCH.Operation;

namespace QLCH.Entity;

public class Sp :IItem
{
    protected bool _isDelete;

    protected string Name { get; set; }
    protected string Label { get; set; }
    protected string Manuf {
        get;
        set;
    }
    public Sp(string name, string label, string manuf)
    {
        _isDelete = false;
        Name = name;
        Label = label;
        Manuf = manuf;
    }

    bool IItem.IsDelete
    {
        get => _isDelete;
        set => _isDelete = value;
    }

    public void AddNewItem()
    {
        throw new NotImplementedException();
    }

    public void RemoveItem()
    {
        _isDelete = true;
    }

    public void UpdateItem(string name, string label,string manuf)
    {
        this.Name = name;
        this.Label = label;
        this.Manuf = manuf;
    }

    public bool isDelete()
    {
        return _isDelete;
    }


    
}