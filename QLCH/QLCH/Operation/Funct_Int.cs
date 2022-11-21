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
    void Remove(string key);
    void Update(string key);
}