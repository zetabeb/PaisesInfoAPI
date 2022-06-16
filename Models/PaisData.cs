namespace PaisesInfoAPI.Models
{
    public class PaisData
    {
        public int id{ get; set; }
        public string nombre { get; set; } = string.Empty;
        public string continente { get; set; } = string.Empty;
        public string capital { get; set; } = string.Empty;
        public string moneda { get; set; } = string.Empty;
        public string indicativoTelefonia { get; set; } = string.Empty;
        public string zonahoraria { get; set; } = string.Empty;
        public string codigoPostal { get; set; } = string.Empty;
        public string idioma { get; set; } = string.Empty;

    }
}