namespace AppService.Core.DTOs
{
    public class AppStatusQuoteGetDto
    {

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public string ClaseCss { get; set; }

        public string FlagModificar { get; set; }

        public bool Editable
        {
            get { if (this.FlagModificar == "X") { return true; } else { return false; } }

        }

        public string FlagEnEspera { get; set; }


        public bool PuedeGanarPerder
        {
            get { if (this.FlagEnEspera == "X") { return true; } else { return false; } }

        }

        public bool EnGrabacion
        {
            get { if (this.Id == 1) { return true; } else { return false; } }

        }

    }
}
