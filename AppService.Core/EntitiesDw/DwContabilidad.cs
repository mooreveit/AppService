using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesDw
{
    public partial class DwContabilidad
    {
        public string Compañia { get; set; }
        public double? Año { get; set; }
        public double? Mes { get; set; }
        public string TipoLibroId { get; set; }
        public string TipoLibroDesc { get; set; }
        public string CuentaId { get; set; }
        public string CuentaDesc { get; set; }
        public string NivelCuenta { get; set; }
        public string BatchTipoId { get; set; }
        public string BatchTipoDesc { get; set; }
        public double? BatchId { get; set; }
        public decimal? FechaBatchSist { get; set; }
        public decimal? FechaBatchReg { get; set; }
        public decimal FechaLm { get; set; }
        public string DocumentoTipoId { get; set; }
        public string DocumentoTipoDesc { get; set; }
        public double DocumentoId { get; set; }
        public double LineaAsiento { get; set; }
        public double? ImporteNeto { get; set; }
        public double? Cantidad { get; set; }
        public string Concepto { get; set; }
        public double? ArticuloNumId { get; set; }
        public string ArticuloAlphId { get; set; }
        public string ArticuloDesc { get; set; }
        public string UnidadNegocioDesc { get; set; }
        public string UnidadNegocio { get; set; }
        public string CuentaObjeto { get; set; }
        public string CuentaAux { get; set; }
        public string CuentaLargaId { get; set; }
        public double? DireccionId { get; set; }
        public string MonedaCompañiaId { get; set; }
        public string MonedaTransaccionId { get; set; }
        public string Posteo { get; set; }
        public string UsuarioInicial { get; set; }
        public string UsuarioFinal { get; set; }
        public string GerenciaId { get; set; }
        public string GerenciaDesc { get; set; }
        public string CategoriaId22 { get; set; }
        public string CategoriaDesc22 { get; set; }
        public string CategoriaId23 { get; set; }
        public string CategoriaDesc23 { get; set; }
        public string CategoriaId24 { get; set; }
        public string CategoriaDesc24 { get; set; }
        public string CategoriaId25 { get; set; }
        public string CategoriaDesc25 { get; set; }
        public string CategoriaId26 { get; set; }
        public string CategoriaDesc26 { get; set; }
        public string CategoriaId27 { get; set; }
        public string CategoriaDesc27 { get; set; }
        public string CategoriaId28 { get; set; }
        public string CategoriaDesc28 { get; set; }
        public string Concepto1 { get; set; }
        public string Concepto2 { get; set; }
    }
}
