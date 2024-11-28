namespace Giornale.Model;

public class CommentoDellaRedazione : Commento
{
    public CommentoDellaRedazione(string testo) : base(testo)
    {
        
    }
    public override string ToString()
    {
        return $"*** {this.Testo}";
    }
}