using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesSap
{
    public partial class Query
    {
        public string Mandant { get; set; }
        public string Objectclas { get; set; }
        public string Objectid { get; set; }
        public string Changenr { get; set; }
        public string Tabname { get; set; }
        public string Tabkey { get; set; }
        public string Fname { get; set; }
        public string Chngind { get; set; }
        public string TextCase { get; set; }
        public string UnitOld { get; set; }
        public string UnitNew { get; set; }
        public string CukyOld { get; set; }
        public string CukyNew { get; set; }
        public string ValueNew { get; set; }
        public string ValueOld { get; set; }
        public string Dataaging { get; set; }
        public string Udate { get; set; }
    }
}
