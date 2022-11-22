using QLCH.DAL;
using QLCH.Operation;

namespace QLCH.Entity;

public class QLDL
{
    public SortedList<string,Sp> DanhSachSanPham { get; set; }
    public SortedList<string,LoaiHang> DanhSachLoaiHang { get; set; }
    public SortedList<string, HDBan>? LichSuBan { get; set; }
    public SortedList<string, HDNhap>? LichSuNhaps { get; set; }
    
    public HDNhap GioHangNhap { get; set; }
    public HDBan GioHangBan { get; set; }

    public QLDL()
    {
        var current = DataWorkFlow.DownloadData();
        this.LichSuBan = current.LichSuBan;
        this.DanhSachSanPham = current.DanhSachSanPham;
        this.DanhSachLoaiHang = current.DanhSachLoaiHang;
        this.LichSuNhaps = current.LichSuNhaps;
        var downloadListLabel = this;
    }

    public bool UploadData()
    {
        return DataWorkFlow.UploadData(this);
    }

    public bool TaoSP(Sp SanPhamMoi)
    {
        var listId = DanhSachSanPham.Keys.ToArray();
        DanhSachSanPham.Add(OpsFunc.TaoID(listId),SanPhamMoi);
        return DanhSachSanPham.ContainsValue(SanPhamMoi) && DataWorkFlow.UploadData(this);
    }

    private string Note(bool ketqua)
    {
        if (ketqua)
        {
            return "Thành Công";
        }
        else
        {
            return "Thất Bại";
        }
    }

    public string LHtao(string LoaiHangmoi)
    {
        LoaiHang loaiHang = new LoaiHang(LoaiHangmoi);
        this.DanhSachLoaiHang.Add(OpsFunc.TaoID(DanhSachLoaiHang.Keys.ToArray()),loaiHang);
        
        return Note(DanhSachLoaiHang.ContainsValue(loaiHang));
    }

    public bool LHxoa(string MaLH)
    {
        DanhSachLoaiHang[MaLH].Remove();
        return true;
    }

    public List<string> LHxuatDS(bool isIncludeDelete)
    {
        var result = new List<string>();
        foreach (var (keykey,loaiHang) in DanhSachLoaiHang)
        {
            if (isIncludeDelete==false && loaiHang.IsDelete)
            {
                continue;
            }
            result.Add(loaiHang.name);
            
        }
        return result;
    }




}