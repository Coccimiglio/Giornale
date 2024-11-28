namespace Giornale.Model;

public class Giornale
{
    private List<Articolo> Articoli = new List<Articolo>();

    public Giornale()
    {

    }

    public Giornale(List<Articolo> articoli)
    {
        this.Articoli = articoli;
    }

    public void AggiungiArticolo(Articolo articolo)
    {
        this.Articoli.Add(articolo);
    }

    public void AggiungiArticoli(List<Articolo> articoli)
    {
        foreach (var item in articoli)
        {
            if (!articoli.Contains(item))
            {
                this.AggiungiArticolo(item);
            }
        }
    }

    public int TrovaArticolo(Articolo articolo)
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