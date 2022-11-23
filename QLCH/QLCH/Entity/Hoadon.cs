using QLCH.DAL;
using QLCH.Operation;

namespace QLCH.Entity;

public class Hoadon : Item
{
    protected string date { get; set; }
    protected List<Chitietdon> Danhsach { get; set; }

    public Hoadon()
    {
        var DSMa = Array.Empty<string>();
        
        IDitem = OpsFunc.TaoID(DSMa);
    }

    public bool Themsp(string MaSp,int Giatrendonvi,int Soluong)
    {
        throw new NotImplementedException();

    }

    public bool ResetMatHang()
    {
        Danhsach.Clear();
        return true;
    }

    public bool XoaMatHang(string MaLoHang)
    {
        throw new NotImplementedException();
    }
}