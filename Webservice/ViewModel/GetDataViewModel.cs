using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Webservice.Enum;
using Webservice.Model;

namespace Webservice.ViewModel
{
    public class GetDataViewModel
    {
        public DataTable DataUp { get; set; }
        public DateTime? CreateDate { get; set; }
        public StatusEnum StatusID { get; set; }
        public string TableName { get; set; }

    }
}
