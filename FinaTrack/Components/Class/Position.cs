namespace FinaTrack.Components.Class;

/// <summary>
/// Modèle abstrait définissant la position d'un élément dans une grille (ligne et colonne).
/// </summary>
public class Position
{
    /// <summary>
    /// Représente le numéro de la ligne dans laquelle est positionné l'élément.
    /// </summary>
    public int Row { get; set; }

    /// <summary>
    /// Représente le numéro de la colonne dans laquelle est positionné l'élément.
    /// </summary>
    public int Column { get; set; }
}