namespace SorteioAPI.Models
{

    public class InfoTelaResponse
    {
        public int VibesAcumulados { get; set; }
        public int NumerosDaSorteQuantidade { get; set; }
        public string NumeroDaSorte { get; set; }
        public List<NumeroDaSorte> SeusNumerosDaSorte { get; set; }
    }

    public class NumeroDaSorte
    {
        public string Numero { get; set; }
        public DateTime RecebidoEm { get; set; }
    }


}
