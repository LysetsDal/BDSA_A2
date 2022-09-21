namespace Assignment2;
using System.Linq;

public static class Queries
{
    public static IEnumerable<string> QueryRowling(this WizardCollection wizards)
    {
        foreach (var w in wizards)
        {
            if(w.Creator.Contains("Rowling"))
                yield return w.Name;
        }
    }

    public static IEnumerable<string> QueryRowlingLinq(this WizardCollection wizards)
    {
        return wizards.AsEnumerable().Where(w => w.Creator.Contains("Rowling"))
            .Select(w => w.Name);
    }

    public static int QueryFirstSith(this WizardCollection wizards)
    {
        int year = Int32.MaxValue;
        foreach (var w in wizards)
        {
            if (w.Name.Contains("Darth ") && w.Year.HasValue && w.Year.Value < year)
                year = w.Year.Value;
        }
        return year;
    }
    
    public static int QueryFirstSithLinq(this WizardCollection wizards)
    {
        // GetValueOrDefault will always be the value, since we have a HasValue requirement in Select
        return wizards.AsEnumerable().Where(w => w.Name.Contains("Darth ") && w.Year.HasValue)
            .Select(w => w)
            .OrderBy(w => w.Year)
            .First().Year.GetValueOrDefault();
    }

    public static IEnumerable<Tuple<string, int?>> QueryWizardsHP(this WizardCollection wizards)
    {
        foreach (var w in wizards)
        {
            if (w.Medium.Contains("Harry Potter"))
                yield return (new Tuple<string, int?>(w.Name, w.Year));
        }
    }
    
    public static IEnumerable<Tuple<string, int?>> QueryWizardsHPLINQ(this WizardCollection wizards)
    {
        return wizards.AsEnumerable().Where(w => w.Medium.Contains("Harry Potter"))
            .Select(w => (new Tuple<string, int?>(w.Name, w.Year)));
    }
    
    public static IEnumerable<string> QueryWizardsGroupCreatorReversed(this WizardCollection wizards)
    {
        var reversed = wizards.OrderByDescending(wizard => wizard.Creator);
        foreach (var w in reversed)
        {
            yield return w.Name;
        }
    }
    
    public static IEnumerable<string> QueryWizardsGroupCreatorReversedLINQ(this WizardCollection wizards)
    {
        return wizards.AsEnumerable().OrderByDescending(w => w.Creator)
            .Select(w => w.Name);
    }
}
