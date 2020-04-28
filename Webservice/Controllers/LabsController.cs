using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Webservice.Enum;
using Webservice.Model;
using Webservice.Services;
using Webservice.Sql;
using Webservice.ViewModel;

namespace Webservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabsController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly ContextDb db;
        private readonly IRepository repo;

        public LabsController(IConfiguration configuration,ContextDb _db,IRepository repository)
        {
            this.configuration = configuration;
            this.db = _db;
            this.repo = repository;
        }

        [HttpGet]
        public string Get()
        {
            return "وب سرویس";
        }


        // GET: api/Labs/TbName
        [HttpGet("{Cnn},{TBName},{PrimaryKey}")]
        public List<GetDataViewModel> Get(string Cnn, string TBName,string PrimaryKey)
        {
            List<GetDataViewModel> DataSync = repo.GetDataViewModels(Cnn, TBName, PrimaryKey);
            //var data = repo.GetRecordFromSyncTable(DataSource,TBName);

            //var AllLabs = db.TblLabs.ToList();
            //List<GetDataViewModel> labsSync = new List<GetDataViewModel>();
            //foreach(var item in SyncTable)
            //{
            //    labsSync.Add(
            //        new GetDataViewModel()
            //        {
            //            lab = AllLabs.Where(f => f.LabID == item.TableID).FirstOrDefault(),
            //            CreateDate=item.CreateDate,
            //            StatusID=(StatusEnum)item.StatusID
            //        }
            //        ) ;


            //    //labsSync.Add(AllLabs.Where(f => f.LabID == item.TableID). .FirstOrDefault());
            //}
            return DataSync;
        }
    }
}
