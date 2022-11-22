using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLCH.DAL;
using QLCH.Entity;

namespace QLCH.Pages;

public class LHmoi : PageModel
{
    public string Nortification { get; set; }
    public QLDL DL = new QLDL();
    [BindProperty] 
    public string NewLabel { get; set; } = null!;

    public void OnGet()
    {
        Nortification = String.Empty;
        Labelist = DL.LHxuatDS(false).ToArray();
    }

    public string[] Labelist { get; set; }

    public void OnPost()    
    {
        string addNewLabel = NewLabel;
        Nortification = DL.LHtao(addNewLabel);
        Labelist = DL.LHxuatDS(false).ToArray();
    }
}