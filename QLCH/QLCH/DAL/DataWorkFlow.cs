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
    // private static FileInfo LoaiHang = new FileInfo("LoaiHang.json");
    // private static FileInfo HDBan = new FileInfo("HDBan.json");
    // private static FileInfo HDNhap = new FileInfo("HDNhap.json");
    // private static FileInfo SanPham = new FileInfo("SanPham.json");
    private static FileInfo Data = new FileInfo("Data.json");
    
    
    // public static List<LoaiHang>? DSLoaiHangsLoad()
    // {
    //     var fileReader = new StreamReader(LoaiHang.FullName);
    //     string Jsonstring = fileReader.ReadToEnd();
    //     fileReader.Close();
    //     return JsonConvert.DeserializeObject<List<LoaiHang>>(Jsonstring);
    // }
    //
    // public static bool DSLoaiHangSave(List<LoaiHang>? loaiHangs)
    // {
    //     if (loaiHangs == null)
    //     {
    //         return false;
    //     }
    //     StreamWriter fileWriter = new StreamWriter(LoaiHang.FullName);
    //     string jsonstring = JsonConvert.SerializeObject(loaiHangs);
    //     fileWriter.Write(jsonstring);
    //     fileWriter.Close();
    //     return true;
    // }
    public static QLDL? DataLoad()
    {
        var fileReader = new StreamReader(Data.FullName);
        string Jsonstring = fileReader.ReadToEnd();
        fileReader.Close();
        return JsonConvert.DeserializeObject<QLDL>(Jsonstring);
    }

    
    public static bool DataSave(QLDL qldl)
    {
        if (qldl == null)
        {
            return false;
        }
        StreamWriter fileWriter = new StreamWriter(Data.FullName);
        string jsonstring = JsonConvert.SerializeObject(Data);
        fileWriter.Write(jsonstring);
        fileWriter.Close();
        return true;
    }
}