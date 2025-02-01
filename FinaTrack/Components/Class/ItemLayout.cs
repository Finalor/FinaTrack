namespace FinaTrack.Components.Class;

/// <summary>
/// Modèle abstrait représentant la disposition d'un item dans l'interface utilisateur.
/// </summary>
public class ItemLayout
{
    /// <summary>
    /// Type de l'item (ex : "Item", "Path", "Indice", etc.).
    /// </summary>
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// Position de l'item dans une grille, définie par une ligne et une colonne.
    /// </summary>
    public Position? Position { get; set; }

    /// <summary>
    /// Chemin d'accès à l'image associée à l'item.
    /// </summary>
    public string? ImagePath { get; set; }
    
    /// <summary>
    /// Chemin d'accès à l'image associée à l'item.
    /// </summary>
    public string? ImagePath2 { get; set; }
    
    /// <summary>
    /// Chemin d'accès à l'image associée à l'item.
    /// </summary>
    public string? ImagePath3 { get; set; }

    /// <summary>
    /// Chemin d'accès à l'image grisée associée à l'item (pour usage désactivé).
    /// </summary>
    public string? GreyImagePath { get; set; }

    /// <summary>
    /// Texte associé à l'item (ex : indication ou description).
    /// </summary>
    public string? TextAssociated { get; set; }

    /// <summary>
    /// Nom ou identifiant d'un autre item potentiellement associé à celui-ci.
    /// </summary>
    public string? ItemAssociated { get; set; }

    /// <summary>
    /// Indique si l'item est actif (true → 1, 2 ou 3) ou non (false → 0).
    /// </summary>
    public int IsActive { get; set; } = 0;
}