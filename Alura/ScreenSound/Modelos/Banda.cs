namespace ScreenSound.Modelos;
class Banda
{
    private List<Album> albums = new List<Album>();
    private List<int> notas = new List<int>();


    //ctor
    public Banda(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }

    public double Media => notas.Average();

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda{Nome}");
        foreach(Album album in albums)
        {
            Console.WriteLine($"Àlbum:{album.Nome} ({album.DuracaoTotal})");
        }
    }

    internal void AdicionarNota(int nota)
    {
        throw new NotImplementedException();
    }

    internal void AvaliarBanda(int v)
    {
        throw new NotImplementedException();
    }
}