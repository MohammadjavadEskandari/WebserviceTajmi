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

        public LabsController(IConfiguration configuration,ContextDb _db)
        {
            this.configuration = configuration;
            this.db = _db;
        }

        [HttpGet]
        public string Get()
        {
            return "وب سرویس";
        }


        // GET: api/Labs/TbName
        [HttpGet("{DataSource},{TBName}")]
        public List<GetLabViewModel> Get(string DataSource, string TBName)
        {
            var SyncTable = db.SyncTable.ToList().OrderBy(f=>f.CreateDate);
            var AllLabs = db.TblLabs.ToList();
            List<GetLabViewModel> labsSync = new List<GetLabViewModel>();
            foreach(var item in SyncTable)
            {
                labsSync.Add(
                    new GetLabViewModel()
                    {
                        lab = AllLabs.Where(f => f.LabID == item.TableID).FirstOrDefault(),
                        CreateDate=item.CreateDate,
                        StatusID=(StatusEnum)item.StatusID
                    }
                    ) ;


                //labsSync.Add(AllLabs.Where(f => f.LabID == item.TableID). .FirstOrDefault());
            }
            return labsSync;
        }
    }
}
