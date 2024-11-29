namespace Giornale.Model;

public class Giornale
{
    private List<Post> Articoli = new List<Post>();

    public Giornale()
    {

    }

    public Giornale(List<Post> articoli)
    {
        this.Articoli = articoli;
    }

    public void AggiungiArticolo(Post articolo)
    {
        this.Articoli.Add(articolo);
    }

    public void AggiungiArticoli(List<Post> articoli)
    {
        foreach (var item in articoli)
        {
            if (!articoli.Contains(item))
            {
                this.AggiungiArticolo(item);
            }
        }
    }

    public int TrovaArticolo(Post articolo)
    {
        foreach (var item in Articoli)
        {
            if (item == articolo)
            {
                return Articoli.IndexOf(item);
            }
        }

        return -1;
    }

    public void CreaCommentoNormale(int index, string text)
    {
        Articoli[index].AggiungiCommento(new Commento(text));
    }

    public void CreaCommentoRedazione(int index, string text)
    {
        Articoli[index].AggiungiCommento(new CommentoDellaRedazione(text));
    }

    public override string ToString()
    {
        string articoli = "";
        foreach (var item in Articoli)
        {
            articoli += $"--ARTICOLO {Articoli.IndexOf(item)+1}--\n{item}\n \n \n";
        }
        return articoli;
    }
}