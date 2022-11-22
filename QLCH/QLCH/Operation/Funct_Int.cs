using QLCH.Entity;

namespace QLCH.Operation;

public interface IItem
{
    protected bool IsDelete { get; set; }
    
    void AddNewItem();


    void RemoveItem()
    {
        throw new NotImplementedException();
    }


    virtual void UpdateItem()
    {
        throw new NotImplementedException();
    }
    
}

public interface Ilist
{
    virtual void Removesoft(string key)
    {
        throw new NotImplementedException();
    }

    virtual void Update(string key, Sp newSP)
    {
        throw new NotImplementedException();
    }

    virtual void AddNewItem()
    {
        throw new NotImplementedException();
    }
}