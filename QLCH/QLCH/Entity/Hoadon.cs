using QLCH.DAL;
using QLCH.Operation;

namespace QLCH.Entity;

public class Hoadon
{
    protected string date { get; set; }
    protected string CreateBy { get; set; }
    protected SortedList<string,Chitietdon> Danhsach { get; set; }

    public bool Themsp(string MaSp,int Giatrendonvi,int Soluong)
    {
        var danhSachSanPham = DataWorkFlow.DownloadData().DanhSachSanPham;
        if (!danhSachSanPham.ContainsKey(MaSp)) return false;
        Chitietdon SanPham = new Chitietdon(MaSp, Giatrendonvi, Soluong);
        Danhsach.Add(OpsFunc.TaoID(Danhsach.Keys.ToArray()),SanPham);
        return true;

    }

    public bool ResetMatHang()
    {
        Danhsach.Clear();
        return true;
    }

    public bool XoaMatHang(string MaLoHang)
    {
        Danhsach.Remove(MaLoHang);
        return true;
    }
}