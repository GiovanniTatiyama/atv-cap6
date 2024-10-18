using System.Reflection.Metadata.Ecma335;

namespace Trafego1.Models;

public class Semaforos
{

    public int SemaforosId { get; set; }

    public string Localizacao { get; set; }

    public string FluxoTrafego { get; set; }

    public Semaforos()
    {
        
    }

    public Semaforos(int semaforosId, string localizacao, string fluxoTrafego)
    {
        SemaforosId = semaforosId;
        Localizacao = localizacao;
        FluxoTrafego = fluxoTrafego;
    }
}