using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using concatjson.Data;
using concatjson.Models;
using concatjson.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace concatjson.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ObjctTestController : ControllerBase
    {
        private readonly ObjctTestRepository _wf;
        private readonly Nest _nest;

        public ObjctTestController(ObjctTestRepository wf, Nest nest)
        {
            _wf = wf;
            _nest = nest;
        }

        [HttpGet]
        public List<NestObjctTest> Get()
        {  
            var lista = _wf.lista();
            var nestlist = _nest.NestingJSON(lista);
            return nestlist;
        }
    }
}
