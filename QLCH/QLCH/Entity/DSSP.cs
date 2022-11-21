using QLCH.Operation;

namespace QLCH.Entity;

public class DSSP : Ilist
{
    public DSSP(SortedList<string, Sp> dssp)
    {
        this.dssp = dssp;
    }

    public SortedList<string,Sp> dssp { get; set; }

    public void Add(string Name)
    {
        throw new NotImplementedException();
    }

    public void Remove(string key)
    {
        throw new NotImplementedException();
    }

    public void Update(string key)
    {
        throw new NotImplementedException();
    }
}