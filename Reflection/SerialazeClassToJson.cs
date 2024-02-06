using Reflections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Reflection
{
    public class SerialazeClassToJson : ISerialaze
    {
        public bool deSerialized(string classN)
        {
          object oClass  =  JsonSerializer.Deserialize<dynamic>(classN);
            if (oClass != null)
                return true;
            return false;
        }

        public string serialized(object classN)
        {
            return JsonSerializer.Serialize(classN);
        }
    }
}
