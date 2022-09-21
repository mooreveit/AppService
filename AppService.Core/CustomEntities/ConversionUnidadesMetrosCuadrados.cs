using System;

namespace AppService.Core.CustomEntities
{
    public class ConversionUnidadesMetrosCuadrados
    {

        public decimal cantidadBase { get; set; }
        public decimal medidaBasica { get; set; }
        public decimal medidaOpuesta { get; set; }

        public decimal ADICIONALPRODUCCION { get; set; }
        public decimal ADICIONALPRODUCCIONOPUESTA { get; set; }
        public decimal MEDIDAOPUESTAROLLO { get; set; }
        public decimal MEDIDABASICAROLLO { get; set; }
        public decimal area { get; set; }



        public ConversionUnidadesMetrosCuadrados(decimal adicionalProduccion, decimal adicionalProduccionOpuesta, decimal medidaBasicaRollo, decimal medidaOpuesRollo)
        {
            this.ADICIONALPRODUCCION = adicionalProduccion;
            this.ADICIONALPRODUCCIONOPUESTA = adicionalProduccionOpuesta;
            this.MEDIDABASICAROLLO = medidaBasicaRollo;
            this.MEDIDAOPUESTAROLLO = medidaOpuesRollo;

        }

        public decimal getCantidadPorUnidad()
        {


            //cantidadBase
            var AREA = ((this.medidaBasica + this.ADICIONALPRODUCCION) / 100) * ((this.medidaOpuesta + this.ADICIONALPRODUCCIONOPUESTA) / 100);

            this.area = AREA;

            //[MEDIDAOPUESTAROLLO]/([MEDIDAOPUESTA]+[ADICIONALPRODUCCIONOPUESTA])
            var UNIDADESPORMEDIDAPUESTAROLLO = this.MEDIDAOPUESTAROLLO / (this.medidaOpuesta + this.ADICIONALPRODUCCIONOPUESTA);

            //[MEDIDABASICAROLLO]/([MEDIDABASICA]+[ADICIONALPRODUCCION])
            var UNIDADESPORBASICAROLLO = this.MEDIDABASICAROLLO / (this.medidaBasica + this.ADICIONALPRODUCCION);

            //[MEDIDAOPUESTAROLLO]/([MEDIDABASICA]+[ADICIONALPRODUCCION])
            var UNIDADESPORMEDIDAPUESTAROLLO2 = this.MEDIDAOPUESTAROLLO / (this.medidaBasica + this.ADICIONALPRODUCCION);

            //[MEDIDABASICAROLLO]/([MEDIDAOPUESTA]+[ADICIONALPRODUCCIONOPUESTA])
            var UNIDADESPORBASICAROLLO2 = this.MEDIDABASICAROLLO / (this.medidaOpuesta + this.ADICIONALPRODUCCIONOPUESTA);


            //[UNIDADESPORMEDIDAPUESTAROLLO]*[UNIDADESPORBASICAROLLO]
            var CANTIDADPORUNIDAD = Math.Truncate(UNIDADESPORMEDIDAPUESTAROLLO) * Math.Truncate(UNIDADESPORBASICAROLLO);

            //[UNIDADESPORMEDIDAPUESTAROLLO2]*[UNIDADESPORBASICAROLLO2]
            var CANTIDADPORUNIDAD2 = Math.Truncate(UNIDADESPORMEDIDAPUESTAROLLO2) * Math.Truncate(UNIDADESPORBASICAROLLO2);


            if (CANTIDADPORUNIDAD > CANTIDADPORUNIDAD2)
            {
                return CANTIDADPORUNIDAD;
            }
            else
            {
                return CANTIDADPORUNIDAD2;
            }


        }

    }

}
