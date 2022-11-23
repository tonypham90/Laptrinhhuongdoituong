using QLCH.DAL;
using QLCH.Operation;

namespace QLCH.Entity;

public class LoaiHang : Item
{
    public LoaiHang( string ten)
    {
        IDitem = OpsFunc.TaoID(QLDL.LHxuatIdList());
        IsDelete = false;
        this.Name = String.Empty;
        this.Name = ten;
    }
    public string ID()
    {
        return IDitem;
    }

    public override bool AddItem()
    {
        if (string.IsNullOrEmpty(this.Name))
        {
            return false;
        }

        var item = this;
        var dl = DataWorkFlow.DataLoad();
        if (dl == null)
        {
            dl = new QLDL();
        }
        dl.DSLH.Add(item);
        DataWorkFlow.DataSave(dl);
        return true;
    }

    public bool LHRemove()
    {
        RemoveItem();
        var DS = QLDL.LHxuatDS(false);
        for (int i = 0; i < DS.Count; i++)
        {
            if (DS[i].ID() == this.IDitem)
            {
                DS[i].RemoveItem();
            }
        }
        return QLDL.LoaiHangUpdateDS(DS);
    }
}