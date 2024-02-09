namespace ScreenSound.Modelos;
class Musica
{
    //tipo primitivo

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
   public Banda Artista { get; }
   public int Duracao { get; set; }

    //nomes que tem primeira letra Maiuscular é uma PROPRIEDADE
   public bool Disponivel { get; set; }


    //Propriedade somente leitura ( lambdas =>)
    public string DescricaoReusumida => $"A música {Nome} pertence à banda {Artista}";

   /*  o get e set do diponivel seria isso :
    *  
    *  get = le
    *  set= escreve
    *  
    * public void  EscreveDisponivel(bool value)
    {
        disponivel = value;
    }


    public bool LeDisponivel()
    {
        return disponivel;
    }*/

    public void ExibirFichaTecnica()
    {
        // cw + tab
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}
