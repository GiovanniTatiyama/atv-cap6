namespace Trafego1.Models;

public class Notificacoes
{
    public int NotificacoesId { get; set; }

    public string ServicoEmergencia { get; set; }
    
    public string ServicoPolicial { get; set; }
    
    public string ServicoSaude { get; set; }
    
    public string ServicoCliente { get; set; }


    public Notificacoes()
    {
        
    }

    public Notificacoes(int notificacoesId, string servicoEmergencia, string servicoPolicial, string servicoSaude, string servicoCliente)
    {
        NotificacoesId = notificacoesId;
        ServicoEmergencia = servicoEmergencia;
        ServicoPolicial = servicoPolicial;
        ServicoSaude = servicoSaude;
        ServicoCliente = servicoCliente;
    }
}