using Newtonsoft.Json;
using QLCH.Entity;

namespace QLCH.DAL;

public static class DataWorkFlow
{
    private static readonly string CurrentDir = Environment.CurrentDirectory;
    private static readonly DirectoryInfo DirectoryInfo = new DirectoryInfo(CurrentDir);
    // private static readonly FileInfo ItemLabelList = new FileInfo("DataLabel.json");
    // private static readonly FileInfo ImportRecord = new FileInfo("DataImportHistory.json");
    // private static FileInfo SaleRecord = new FileInfo("DataSaleHistory.json");
    // private static readonly FileInfo ItemStore = new FileInfo("DataStore.json");
    private static FileInfo DLCH = new FileInfo("DLCH.json");
    
    //space for label
    // public static bool AddNewLabel(string? newLabel)
    // {
    //     List<string> currentLabel = DownloadListLabel();
    //     if (newLabel != null)
    //     {
    //         newLabel = newLabel.ToUpper();
    //         
    //         if (currentLabel.Contains(newLabel))
    //         {
    //             return false;
    //         }
    //         currentLabel.Add(newLabel);
    //     }
    //     return UploadLabel(currentLabel);
    // }
    //
    // public static List<string> DownloadListLabel()
    // {
    //     List<string> resList = new List<string>();
    //     StreamReader fileReader = new StreamReader(ItemLabelList.FullName);
    //     string jsonstring = fileReader.ReadToEnd();
    //     fileReader.Close();
    //     if (string.IsNullOrEmpty(jsonstring))
    //     {
    //         return resList;
    //     }
    //     resList = JsonConvert.DeserializeObject<List<string>>(jsonstring) ?? throw new InvalidOperationException();
    //     return resList;
    // }
    //
    // public static bool UploadLabel(List<string> listLabel)
    // {
    //     if (listLabel.Count==0)
    //     {
    //         return false;
    //     }
    //     StreamWriter fileWriter = new StreamWriter(ItemLabelList.FullName);
    //     string jsonstring = JsonConvert.SerializeObject(listLabel);
    //     fileWriter.Write(jsonstring);
    //     fileWriter.Close();
    //     return true;
    // }
    //
    // //end space for label
    //
    // //Store info
    // public static List<DSSP>? DownloadListItem()
    // {
    //     List<DSSP>? resList = new List<DSSP>();
    //     StreamReader fileReader = new StreamReader(ItemStore.FullName);
    //     string jsonstring = fileReader.ReadToEnd();
    //     fileReader.Close();
    //     if (string.IsNullOrEmpty(jsonstring))
    //     {
    //         return resList;
    //     }
    //     resList = JsonConvert.DeserializeObject<List<DSSP>>(jsonstring) ?? throw new InvalidOperationException();
    //     return resList;
    // }
    //
    // public static bool UploadItemList(List<int>? listItems)
    // {
    //     if (listItems.Count==0)
    //     {
    //         return false;
    //     }
    //     StreamWriter fileWriter = new StreamWriter(ItemStore.FullName);
    //     string jsonstring = JsonConvert.SerializeObject(listItems);
    //     fileWriter.Write(jsonstring);
    //     fileWriter.Close();
    //     return true;
    // }
    //
    // //End Of store info
    //
    // //import store
    // public static List<DSSP>? LoadImportHistory()
    // {
    //     StreamReader fileReader = new StreamReader(ImportRecord.FullName);
    //     string Jsonstring = fileReader.ReadToEnd();
    //     fileReader.Close();
    //     return JsonConvert.DeserializeObject<List<DSSP>>(Jsonstring);
    // }
    //
    // public static bool UploadImportHistory(List<DSSP> Historylist)
    // {
    //     StreamWriter fileWriter = new StreamWriter(ImportRecord.FullName);
    //     fileWriter.Write(JsonConvert.SerializeObject(Historylist));
    //     fileWriter.Close();
    //     return true;
    // }
    //
    // //End Import
    //
    // //Sale record
    
    public static QLDL DownloadData()
    {
        QLDL dlCuaHang = new QLDL();
        StreamReader fileReader = new StreamReader(DLCH.FullName);
        string jsonstring = fileReader.ReadToEnd();
        fileReader.Close();
        if (string.IsNullOrEmpty(jsonstring))
        {
            return dlCuaHang;
        }
        dlCuaHang = JsonConvert.DeserializeObject<QLDL>(jsonstring) ?? throw new InvalidOperationException();
        return dlCuaHang;
    }

    public static bool UploadData(QLDL? duLieuCuaHang)
    {
        if (duLieuCuaHang == null)
        {
            return false;
        }
        StreamWriter fileWriter = new StreamWriter(DLCH.FullName);
        string jsonstring = JsonConvert.SerializeObject(duLieuCuaHang);
        fileWriter.Write(jsonstring);
        fileWriter.Close();
        return true;
    }
}