
namespace ScreenSound.Modelos;

//interface
internal interface IAvaliado
{
    void AdicionarNota(Avaliacao nota);
    //assinatura de propriedade
    double Media { get; }
}
