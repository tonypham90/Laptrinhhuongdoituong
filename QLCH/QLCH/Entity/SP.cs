using System.Reflection.Emit;
using Microsoft.AspNetCore.Mvc;
using QLCH.Operation;

namespace QLCH.Entity;

public class Sp :Item
{
    
    protected string MaLoaiHang { get; set; }
    protected string Manuf {
        get;
        set;
    }
    public Sp(string name, string maLoai, string manuf)
    {
        IsDelete = false;
        Name = name;
        MaLoaiHang = maLoai;
        Manuf = manuf;
    }

    public override bool AddItem()
    {
        throw new NotImplementedException();
    }
    
    public void RemoveItem()
    {
        IsDelete = true;
    }

    public void UpdateItem(string name, string label,string manuf)
    {
        this.Name = name;
        this.MaLoaiHang = label;
        this.Manuf = manuf;
    }



}