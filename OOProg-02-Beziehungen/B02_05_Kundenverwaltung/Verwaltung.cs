namespace B02_05_Kundenverwaltung;

public class Verwaltung
{
    #region fields

    private Dictionary<string, Kunde> _dictKunden;

    #endregion

    #region ctor
    public Verwaltung()
    {
        _dictKunden = new Dictionary<string, Kunde>();
    }
    #endregion
    
    #region methods
    public void Print()
    {
        Console.WriteLine("\nKundenverwaltung");
        foreach (var kunde in _dictKunden.Values)
        {
            if (kunde == null) continue;
            Console.WriteLine(kunde.AsString());        
        }
    } 
    
    // Assoziationsmethoden
    public void Add(Kunde kunde)
    {
        _dictKunden[kunde.Id] = kunde;
    }

    public void Remove(Kunde kunde)
    {
        if (_dictKunden.ContainsKey(kunde.Id))
        {
            _dictKunden.Remove(kunde.Id);
        }
        else
        {
            throw new Exception("Kundenverwaltung.Remove() - Kunde existiert nicht!!");
        }
    }

    public Kunde Find(string firmenName)
    {
        if (string.IsNullOrEmpty(firmenName)) throw new ArgumentException("Kundenverwaltung.Find() - Kunde ist null");

        foreach (Kunde kunde in _dictKunden.Values)
        {
            if (kunde.FirmenName.Trim().ToLower() == firmenName.Trim().ToLower())
            {
                return kunde; 
            }
        }
        throw new Exception("Kundernverwaltung.Find() - Firmenname nicht gefunden");
    }
    #endregion
}