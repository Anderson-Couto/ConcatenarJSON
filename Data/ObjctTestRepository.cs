using System.Collections.Generic;
using concatjson.Models;

namespace concatjson.Data
{
    public class ObjctTestRepository
    {
        public ObjctTestRepository()
        {
            
        }

        public List<ObjctTest> lista(){
            List<ObjctTest> wf = new List<ObjctTest>(){
                new ObjctTest {a = 40, b =  100, c = "Texto A"},
                new ObjctTest {a = 80, b =  150, c = "Texto C"},
                new ObjctTest {a = 60, b =  120, c = "Texto B"},
                new ObjctTest {a = 60, b =  110, c = "Texto A"},
                new ObjctTest {a = 80, b =  130, c = "Texto B"},
                new ObjctTest {a = 80, b =  140, c = "Texto C"},
            };
            return wf;
        }
    }
}