namespace JellyfinOnePaceMetadata.Model;

public class OnePaceMetadataJson {
    public DateTime LastUpdate { get; set; }
    public int LastUpdateTs { get; set; }
    public string BaseUrl { get; set; }
    public TvShow TvShow { get; set; }
    public List<Arc> Arcs { get; set; }
    public Dictionary<string, EpisodeData> Episodes { get; set; }
}
public class TvShow {
    public string Title { get; set; }
    public string SortTitle { get; set; }
    public string OriginalTitle { get; set; }
    public List<string> Genre { get; set; }
    public string Premiered { get; set; }
    public string ReleaseDate { get; set; }
    public int Season { get; set; }
    public int Episode { get; set; }
    public string Status { get; set; }
    public int Year { get; set; }
    public string Plot { get; set; }
    public bool LockData { get; set; }
    public string CustomRating { get; set; }
}

public class Arc {
    public int Part { get; set; }
    public string Saga { get; set; }
    public string Title { get; set; }
    public string OriginalTitle { get; set; }
    public string Description { get; set; }
    public string Poster { get; set; }
}

public class EpisodeData {
    public int Arc { get; set; }
    public int Episode { get; set; }
    public string Title { get; set; }
    public string OriginalTitle { get; set; }
    public string Description { get; set; }
    public string Chapters { get; set; }
    public string Episodes { get; set; }
    public string Released { get; set; }
    public Dictionary<string, string> Hashes { get; set; }
}