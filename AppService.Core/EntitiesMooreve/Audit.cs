using System;
using System.Collections.Generic;

namespace AppService.Core.EntitiesMooreve
{
    public partial class Audit
    {
        public string Type { get; set; }
        public string TableName { get; set; }
        public string Pk { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UserName { get; set; }
    }
}
