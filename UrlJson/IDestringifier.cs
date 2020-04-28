using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrlJson
{
    public interface IDestringifier
    {
        T Destringify<T>(string obj) where T : class;
    }
}
