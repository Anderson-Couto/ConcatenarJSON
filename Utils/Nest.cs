using System.Collections.Generic;
using System;
using concatjson.Models;

namespace concatjson.Utils
{
    public class Nest
    {
        public List<NestObjctTest> NestingJSON(List<ObjctTest> wf)
        {   
            List<NestObjctTest> nestlist = new List<NestObjctTest>(){};

            foreach (ObjctTest item in wf)
            {
                if (nestlist.Exists(i => i.referencia == item.c))
                {
                    NestObjctTest nwf = nestlist.Find(i => i.referencia == item.c);
                    nwf.nest.Add(item);                   
                }
                else
                {
                    nestlist.Add(
                        new NestObjctTest() {
                            referencia = item.c,
                            nest = new List<ObjctTest>(){item},
                    });
                }
            }

            return nestlist;
        }
    }
}