namespace QLCH.Entity;

public class Chitietdon
{
    public string MaSP { get; set; }
    public int PricePerUnit { get; set; }
    public int Qty { get; set; }
    public Chitietdon(string maSp,int pricePerUnit,int qty)
    {
        this.MaSP = maSp;
        this.Qty = qty;
        this.PricePerUnit = pricePerUnit;
    }

    public int TotalPrice()
    {
        return this.Qty * PricePerUnit;
    }
}