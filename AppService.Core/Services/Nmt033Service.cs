using AppService.Core.EntitiesNomina;
using AppService.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class Nmt033Service : INmt033Service
    {

        private readonly IUnitOfWork _unitOfWork;



        public Nmt033Service(IUnitOfWork unitOfWork)

        {
            this._unitOfWork = unitOfWork;


        }

        public async Task UpdateByYearMonth(decimal fproAnocal, decimal mescal)
        {
            await this._unitOfWork.Nmt033Repository.DeleteMonth(fproAnocal, mescal);
            await this._unitOfWork.SaveChangesAsync();

            List<Nmt033> newNmt033List = new List<Nmt033>();

            var nmt033List = await _unitOfWork.SpiNmt033Repository.GetListByYearMonth(fproAnocal, mescal);
            if (nmt033List != null && nmt033List.Count > 0)
            {
                foreach (var item in nmt033List)
                {
                    Nmt033 newNmt033 = new Nmt033();
                    newNmt033.CIA_CODCIA = item.CIA_CODCIA;
                    newNmt033.TNOM_TIPNOM = item.TNOM_TIPNOM;
                    newNmt033.PROC_TIPPRO = item.PROC_TIPPRO;
                    newNmt033.SUBPRO = item.SUBPRO;
                    newNmt033.ANOCAL = item.ANOCAL;
                    newNmt033.NUMPER = item.NUMPER;
                    newNmt033.DESPER = item.DESPER;
                    newNmt033.FECINI = item.FECINI;
                    newNmt033.FECFIN = item.FECFIN;
                    newNmt033.FECPAG = item.FECPAG;
                    newNmt033.MESCAL = item.MESCAL;
                    newNmt033.NUMNOM = item.NUMNOM;
                    newNmt033.ULTNOM = item.ULTNOM;
                    newNmt033.FORPAG = item.FORPAG;
                    newNmt033.ESTPER = item.ESTPER;
                    newNmt033.PRORET = item.PRORET;
                    newNmt033.FECSAL = item.FECSAL;
                    newNmt033.FPRO_TIPPRO = item.FPRO_TIPPRO;
                    newNmt033.FPRO_SUBPRO = item.FPRO_SUBPRO;
                    newNmt033.FPRO_ANOCAL = item.FPRO_ANOCAL;
                    newNmt033.FPRO_NUMPER = item.FPRO_NUMPER;
                    newNmt033.CUOSAL = item.CUOSAL;
                    newNmt033.CUOREG = item.CUOREG;
                    newNmt033.TIPCOM = item.TIPCOM;
                    newNmt033.NUMCOM = item.NUMCOM;
                    newNmt033.FECCOM = item.FECCOM;
                    newNmt033.ANOCON = item.ANOCON;
                    newNmt033.MESCON = item.MESCON;
                    newNmt033.FUNDIF = item.FUNDIF;
                    newNmt033.TIPDIF = item.TIPDIF;
                    newNmt033.NUMDIF = item.NUMDIF;
                    newNmt033.FECDIF = item.FECDIF;
                    newNmt033.ANODIF = item.ANODIF;
                    newNmt033.MESDIF = item.MESDIF;
                    newNmt033.FACDIF = item.FACDIF;
                    newNmt033.FPRO_TIPPR1 = item.FPRO_TIPPR1;
                    newNmt033.FPRO_SUBPR1 = item.FPRO_SUBPR1;
                    newNmt033.FPRO_ANOCA1 = item.FPRO_ANOCA1;
                    newNmt033.FPRO_NUMPE1 = item.FPRO_NUMPE1;
                    newNmt033.STAT_CODSTA = item.STAT_CODSTA;
                    newNmt033.BUSCOL = item.BUSCOL;
                    newNmt033.FECIND = item.FECIND;
                    newNmt033.FECINH = item.FECINH;
                    newNmt033.FECRED = item.FECRED;
                    newNmt033.FECREH = item.FECREH;
                    newNmt033.UNITIE = item.UNITIE;
                    newNmt033.TIEFRC = item.TIEFRC;
                    newNmt033.DIAING = item.DIAING;
                    newNmt033.DIARET = item.DIARET;
                    newNmt033.TIPFED = item.TIPFED;
                    newNmt033.TIPFEF = item.TIPFEF;
                    newNmt033.TIPFEH = item.TIPFEH;
                    newNmt033.USRCRE = item.USRCRE;
                    newNmt033.FECCRE = item.FECCRE;
                    newNmt033.USRACT = item.USRACT;
                    newNmt033.FECACT = item.FECACT;
                    newNmt033.FECHA1 = item.FECHA1;
                    newNmt033.FECHA2 = item.FECHA2;
                    newNmt033.FECHA3 = item.FECHA3;
                    newNmt033.FECESQ = item.FECESQ;
                    newNmt033.FECRET = item.FECRET;
                    newNmt033.MDES_CODDES = item.MDES_CODDES;
                    newNmt033.INIANI = item.INIANI;
                    newNmt033.FINANI = item.FINANI;
                    newNmt033.POSCOM = item.POSCOM;
                    newNmt033.POSDIF = item.POSDIF;
                    //_unitOfWork.Nmm024Repository.Add(newNmm024);
                    //this._unitOfWork.SaveChanges();
                    newNmt033List.Add(newNmt033);

                }


                await _unitOfWork.Nmt033Repository.AddRange(newNmt033List);

                this._unitOfWork.SaveChanges();




            }




        }
    }
}
