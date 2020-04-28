using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Webservice.Model;
using Webservice.ViewModel;

namespace Webservice.Services
{
    public interface IRepository
    {
        List<GetDataViewModel> GetDataViewModels(string Cnn, string TbName, string PrimaryKey);
        //DataTable GetRecordFromTable(string Cnn, string TbName);
        //List<SyncTable> GetRecordFromSyncTable (string Cnn,string TbName);

    }
}
