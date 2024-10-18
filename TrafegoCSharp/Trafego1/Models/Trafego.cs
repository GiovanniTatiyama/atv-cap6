using System.ComponentModel.DataAnnotations.Schema;

namespace Trafego1.Models
{
    
    
    
    public class Trafego
    {
        
        
        public int TrafegoId { get; set; }
        public int Rotas { get; set; }
        public string OtimizacaoRotas { get; set; }
        public string AnaliseVias { get; set; }
        public string AnaliseCongestionamento { get; set; } = ""; 
        public string CondicoesClimaticas { get; set; } = ""; 

        public Trafego()
        {
            
        }

        public Trafego(int trafegoId, int rotas, string otimizacaoRotas, string analiseVias, string analiseCongestionamento, string condicoesClimaticas)
        {
            TrafegoId = trafegoId;
            Rotas = rotas;
            OtimizacaoRotas = otimizacaoRotas;
            AnaliseVias = analiseVias;
            AnaliseCongestionamento = analiseCongestionamento;
            CondicoesClimaticas = condicoesClimaticas;
        }
    }
}