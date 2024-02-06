using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public interface ISerialaze
    {
        string serialized(object classN);
        bool deSerialized(string classN);
    }
}
