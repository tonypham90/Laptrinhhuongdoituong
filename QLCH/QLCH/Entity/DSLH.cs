using System.Collections;
using QLCH.Operation;

namespace QLCH.Entity;

public class DSLH : Ilist, IEnumerable
{
    public SortedList<string,LoaiHang> dslh { get; set; }


    public void Add(string Name)
    {
        throw new NotImplementedException();
    }

    public void Removesoft(string key)
    {
        throw new NotImplementedException();
    }

    public void Update(string key, LoaiHang newSP)
    {
        throw new NotImplementedException();
    }

    public List<string> Export(bool IncludeDeleted)
    {
        var DS = new List<string>();
        foreach (var loaiHang in dslh)
        {
            if (loaiHang.Value.IsDelete && !IncludeDeleted)
            {
                continue;
            }
            DS.Add(loaiHang.Value.name);
        }

        return DS;
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}