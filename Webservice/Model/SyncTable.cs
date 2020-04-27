using System;

namespace Webservice.Model
{
    public class SyncTable
    {
        public int ID { get; set; }
        public string CommandText { get; set; }
        public string TableName { get; set; }
        public int? TableID { get; set; }
        public int? CenterCode { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? StatusID { get; set; }


    }

}
