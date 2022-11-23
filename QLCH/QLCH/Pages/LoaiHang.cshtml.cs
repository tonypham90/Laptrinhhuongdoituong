using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLCH.DAL;
using QLCH.Entity;
using QLCH.Operation;

namespace QLCH.Pages;

public class LHmoi : PageModel
{
    public string Nortification { get; set; }
    public List<LoaiHang>? DSLH = QLDL.LHxuatDS(false);
    [BindProperty] 
    public string LoaiHangMoi { get; set; }

    public void OnGet()
    {
        Nortification = string.Empty;
        LoaiHangMoi = string.Empty;
        
    }

    public void OnPost()    
    {
        var loai = new LoaiHang(LoaiHangMoi);
        Nortification = OpsFunc.Notification(loai.AddItem());
    }
}