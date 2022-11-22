using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLCH.DAL;
using QLCH.Entity;
using QLCH.Operation;

namespace QLCH.Pages;

public class SPmoi : PageModel
{

    public QLDL DL;
    public string[] ListLabel = DataWorkFlow.DownloadData().LHxuatDS(false).ToArray();
   
    public bool StatusRequestAddItem;
    [BindProperty]
    public string Notification { get; set; }
    [BindProperty]
    public string ItemName { get; set; }
    [BindProperty]
    public string ItemLabel { get; set; }
    [BindProperty]
    public string ItemManuf { get; set; }
    [BindProperty]
    public int ItemQty { get; set; }
    [BindProperty]
    public int ItemPrice { get; set; }
    [BindProperty]
    public DateTime ItemExp { get; set; }
    [BindProperty]
    public DateTime ItemMfg { get; set; }
    
    
    public void OnGet()
    {
        // ItemId = ManipulateFunction.CreateItemId();
        ItemName = String.Empty;
        ItemManuf = String.Empty;
        ItemLabel = String.Empty;
        Notification = String.Empty;

    }

    public void OnPost()
    {
        var newItem = new Sp(ItemName,ItemLabel,ItemManuf);
        
        StatusRequestAddItem = DL.TaoSP(newItem);
        switch (StatusRequestAddItem)
        {
            case true:
                Notification = $"Mat hang da duoc tao thanh cong";
                break;
            case false:
                Notification = $"That bai, Kiem tra lai thong tin mat hang duoc nhap vao";
                break;
        }
    }
}