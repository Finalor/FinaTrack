namespace FinaTrack.Components.Class;

/// <summary>
/// Représente la disposition générale d'un ensemble d'items dans une grille.
/// </summary>
public class ItemTrackerLayout
{
    /// <summary>
    /// Le nombre total de colonnes dans la grille.
    /// </summary>
    public int NbColonne { get; set; }

    /// <summary>
    /// Le nombre total de lignes dans la grille.
    /// </summary>
    public int NbLigne { get; set; }

    /// <summary>
    /// Liste des items à afficher dans la grille.
    /// </summary>
    public List<ItemLayout> Items { get; set; } = [];
}