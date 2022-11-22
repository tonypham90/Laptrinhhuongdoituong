using QLCH.Operation;

namespace QLCH.Entity;

public class DSSP : Ilist
{
    private SortedList<string,Sp> dssp { get; set; }

    public void Addnew(Sp SPmoi)
    {
        var listId = dssp.Keys.ToArray();
        dssp.Add(OpsFunc.TaoID(listId),SPmoi);
    }

    public void Removesoft(string key)
    {
        dssp[key].RemoveItem();
    }

    public void Update(string key,Sp SpCapnhat)
    {
        dssp.Remove(key);
        dssp.Add(key,SpCapnhat);
    }
    public SortedList<string, Sp> Export(bool includeDelete)
    {
        switch (includeDelete)
        {
            case true:
                return dssp;
            case false:
                SortedList<string, Sp> danhsachhientai = dssp;
                foreach (var item in dssp.Where(item => item.Value.isDelete()))
                {
                    danhsachhientai.Remove(item.Key);
                }
                return danhsachhientai;
        }
    }

    public bool isIteminlist(Sp Item)
    {
       return dssp.ContainsValue(Item);
    }

    public bool isItemDeleted(Sp Item)
    {
        return Item.isDelete();
    }
}