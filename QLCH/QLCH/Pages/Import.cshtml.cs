using Microsoft.AspNetCore.Mvc.RazorPages;

namespace QLCH.Pages;

public class Import : PageModel
{
    // public List<ImportRecord> HistoryImportRecords = ImportStore.RequestLoadImportRecords();
    // [BindProperty] public List<ImportRecord> ImportShow { get; set; }
    // [BindProperty] public string choicefunc { get; set; }
    //
    // [BindProperty]
    // public string keyword { get; set; }
    // public void OnGet()
    // {
    //     ImportShow = HistoryImportRecords;
    //     keyword = string.Empty;
    // }
    //
    // public void OnPost()
    // {
    //     if (string.IsNullOrEmpty(keyword))
    //     {
    //         ImportShow = HistoryImportRecords;
    //     }
    //
    //     ImportShow = ImportStore.FindListRecords(keyword, choicefunc);
    // }
}