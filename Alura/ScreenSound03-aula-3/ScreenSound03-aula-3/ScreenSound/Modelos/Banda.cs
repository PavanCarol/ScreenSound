﻿namespace ScreenSound.Modelos;


//Banda implementa a interface da Avaliado
internal class Banda : IAvaliado
{
    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public Banda(string nome)
    {
        Nome = nome;
    }
    public IEnumerable<Album> Albuns => albuns;
    public string Nome { get; }


    //crt +k +c ==colocar todas as linhas 
    //ctr +k+u  ==desativar o bagulho
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    
    public string? Resumo { get; set; }
  
    public void AdicionarAlbum(Album album) 
    { 
        albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}