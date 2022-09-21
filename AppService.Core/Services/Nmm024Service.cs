using AppService.Core.EntitiesNomina;
using AppService.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class Nmm024Service : INmm024Service
    {

        private readonly IUnitOfWork _unitOfWork;



        public Nmm024Service(IUnitOfWork unitOfWork)

        {
            this._unitOfWork = unitOfWork;


        }

        public async Task UpdateByYearMonth(decimal fproAnocal, decimal mescal)
        {
            await this._unitOfWork.Nmm024Repository.DeleteMonth(fproAnocal, mescal);
            await this._unitOfWork.SaveChangesAsync();



            List<Nmm024> newNmm024List = new List<Nmm024>();

            var NMM024List = await _unitOfWork.SpiNmm024Repository.GetListByYearMonth(fproAnocal, mescal);
            if (NMM024List != null && NMM024List.Count > 0)
            {
                foreach (var item in NMM024List)
                {
                    Nmm024 newNmm024 = new Nmm024();
                    newNmm024.CIA_CODCIA = item.CIA_CODCIA;
                    newNmm024.TNOM_TIPNOM = item.TNOM_TIPNOM;
                    newNmm024.CODSUC = item.CODSUC;
                    newNmm024.PROC_TIPPRO = item.PROC_TIPPRO;
                    newNmm024.SUBPRO = item.SUBPRO;
                    newNmm024.FPRO_ANOCAL = item.FPRO_ANOCAL;
                    newNmm024.MESCAL = item.MESCAL;
                    newNmm024.FPRO_NUMPER = item.FPRO_NUMPER;
                    newNmm024.TRAB_SUBTIP = item.TRAB_SUBTIP;
                    newNmm024.TRAB_FICTRA = item.TRAB_FICTRA;
                    newNmm024.CIA_CODACT = item.CIA_CODACT;
                    newNmm024.TRAB_SBTACT = item.TRAB_SBTACT;
                    newNmm024.TRAB_FICACT = item.TRAB_FICACT;
                    newNmm024.PRIEJE = item.PRIEJE;
                    newNmm024.CTO_CODCTO = item.CTO_CODCTO;
                    newNmm024.TABGEN = item.TABGEN;
                    newNmm024.FECMOV = item.FECMOV;
                    newNmm024.FUNCTO = item.FUNCTO;
                    newNmm024.TIPCAL = item.TIPCAL;
                    newNmm024.TIPFIS = item.TIPFIS;
                    newNmm024.TIPSUE = item.TIPSUE;
                    newNmm024.FECSUE = item.FECSUE;
                    newNmm024.SUEANT = item.SUEANT;
                    newNmm024.TIPANT = item.TIPANT;
                    newNmm024.PROM_CODPRO = item.PROM_CODPRO;
                    newNmm024.SUESUS = item.SUESUS;
                    newNmm024.PROM_PROSUS = item.PROM_PROSUS;
                    newNmm024.SUECAL = item.SUECAL;
                    newNmm024.CANCTO = item.CANCTO;
                    newNmm024.CANIMP = item.CANIMP;
                    newNmm024.CUOREG = item.CUOREG;
                    newNmm024.FACCAL = item.FACCAL;
                    newNmm024.VALCAL = item.VALCAL;
                    newNmm024.MONCTO = item.MONCTO;
                    newNmm024.MONORI = item.MONORI;
                    newNmm024.SALDOT = item.SALDOT;
                    newNmm024.TRAB_FICSUP = item.TRAB_FICSUP;
                    newNmm024.TABU_CODTAB = item.TABU_CODTAB;
                    newNmm024.MANINS = item.MANINS;
                    newNmm024.CTO_CTOAHO = item.CTO_CTOAHO;
                    newNmm024.TIPI_TIPAHO = item.TIPI_TIPAHO;
                    newNmm024.INSD_INSAHO = item.INSD_INSAHO;
                    newNmm024.CTAAHO = item.CTAAHO;
                    newNmm024.TCTA_TIPAHO = item.TCTA_TIPAHO;
                    newNmm024.DPTO_CODDEP = item.DPTO_CODDEP;
                    newNmm024.DGRT_CODGRU = item.DGRT_CODGRU;
                    newNmm024.RGRU_CONGRU = item.RGRU_CONGRU;
                    newNmm024.RGRU_CONGRU = item.RGRU_CONGRU;
                    newNmm024.CTACON = item.CTACON;
                    newNmm024.ORDTRA = item.ORDTRA;
                    newNmm024.CODOPE = item.CODOPE;
                    newNmm024.DEPALT = item.DEPALT;
                    newNmm024.POSVAC = item.POSVAC;
                    newNmm024.NOSUMA = item.NOSUMA;
                    newNmm024.NOIMPR = item.NOIMPR;
                    newNmm024.NONETO = item.NONETO;
                    newNmm024.TASINT = item.TASINT;
                    newNmm024.RETISR = item.RETISR;
                    newNmm024.CONARM = item.CONARM;
                    newNmm024.CONCHE = item.CONCHE;
                    newNmm024.CONCUO = item.CONCUO;
                    newNmm024.MRETRO = item.MRETRO;
                    newNmm024.USERID = item.USERID;
                    newNmm024.FECSIS = item.FECSIS;
                    newNmm024.AFECHE = item.AFECHE;
                    newNmm024.CODBEN = item.CODBEN;
                    newNmm024.DESADI = item.DESADI;
                    newNmm024.MONCUO = item.MONCUO;
                    newNmm024.INIDES = item.INIDES;
                    newNmm024.SOLOPAGO = item.SOLOPAGO;
                    newNmm024.FECMES = item.FECMES;
                    newNmm024.ABONAR = item.ABONAR;
                    newNmm024.ID_PUESTO = item.ID_PUESTO;
                    newNmm024.ID_PERSONA = item.ID_PERSONA;
                    newNmm024.CONTROL = item.CONTROL;
                    newNmm024.ID_MOTIVO_HE = item.ID_MOTIVO_HE;

                    //_unitOfWork.Nmm024Repository.Add(newNmm024);
                    //this._unitOfWork.SaveChanges();
                    newNmm024List.Add(newNmm024);

                }


                await _unitOfWork.Nmm024Repository.AddRange(newNmm024List);

                this._unitOfWork.SaveChanges();

                this._unitOfWork.Nmm024Repository.ExecEstadisticas(fproAnocal, mescal);


            }




        }
    }
}
