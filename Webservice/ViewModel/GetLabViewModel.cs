using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webservice.Enum;
using Webservice.Model;

namespace Webservice.ViewModel
{
    public class GetLabViewModel
    {
        public Lab lab { get; set; }
        public DateTime? CreateDate { get; set; }
        public StatusEnum StatusID { get; set; }

    }
}
