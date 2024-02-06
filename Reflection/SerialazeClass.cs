using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class SerialazeClass
    {

        ISerialaze _serialaze {  get; set; }

        public SerialazeClass(ISerialaze serialaze) => _serialaze = serialaze;

        public  string Serialazed(object classN)
        {
            return _serialaze.serialized(classN);
        }

        public bool Serialazed(string classN)
        {
            return _serialaze.deSerialized(classN);
        }
    }
}
