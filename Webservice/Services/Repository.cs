using Dapper;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Webservice.Model;
using Webservice.ViewModel;

namespace Webservice.Services
{
    public class Repository : IRepository
    {
        private List<SyncTable> GetRecordFromSyncTable(string Cnn, string TbName)
        {

            string sql = "select * from SyncTable where TableName= " + TbName;

            List<SyncTable> data = new List<SyncTable>();

            using (var connection = new SqlConnection(Cnn))
            {
                data = connection.Query<SyncTable>(sql).ToList();
            }

            return data;

        }
        private DataTable GetRecordFromTable(string Cnn, string TbName, List<SyncTable> Sync, string PrimaryKey)
        {
            var s = Sync.Select(f => f.TableID).ToArray();

            SqlConnection con = new SqlConnection(Cnn);
            string qu = "select * from " + TbName + " where " + PrimaryKey + " in(";
            int i = 1;
            foreach (var item in s)
            {
                if (i == s.Count())
                    qu = qu + item;
                else
                    qu = qu + item + ",";
                i++;
            }
            qu = qu + ")";


            SqlDataAdapter adp = new SqlDataAdapter(qu, con);
            DataTable dt = new DataTable();


            try
            {
                con.Open();
                adp.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dt;

        }

        public List<GetDataViewModel> GetDataViewModels(string Cnn, string TbName, string PrimaryKey)
        {
            List<SyncTable> SyncTable = GetRecordFromSyncTable(Cnn, TbName);

            DataTable Records = GetRecordFromTable(Cnn, TbName, SyncTable, PrimaryKey);

            List<GetDataViewModel> labsSync = new List<GetDataViewModel>();

            foreach (var item in SyncTable)
            {
                var ds = Records.Select(PrimaryKey + "=" + item.TableID);
            }


            //foreach (var item in SyncTable)
            //{
            //    labsSync.Add(
            //        new GetDataViewModel()
            //        {
            //            lab = AllLabs.Where(f => f.LabID == item.TableID).FirstOrDefault(),
            //            CreateDate = item.CreateDate,
            //            StatusID = (StatusEnum)item.StatusID
            //        }
            //        );


            //    //labsSync.Add(AllLabs.Where(f => f.LabID == item.TableID). .FirstOrDefault());
            //}
            return labsSync;
        }
    }
}
