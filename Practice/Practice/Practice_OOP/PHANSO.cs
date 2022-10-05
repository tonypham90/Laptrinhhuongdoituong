namespace Practice_OOP;

public class Phanso
{
    private int _tuso;
    private int _mauso;

    public int tuso
    {
        get => this._tuso;
        set => _tuso = value;
    }

    public int mauso
    {
        get => this._mauso;
        set
        {
            if (value!=0)
            {
                _mauso = value;
            }
            else
            {
                var ex = new Exception("Ban da chia cho so 0");
                throw ex;
            }
        }
    }
    
    
}