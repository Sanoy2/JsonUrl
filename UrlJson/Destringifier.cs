using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrlJson
{
    public class Destringifier : IDestringifier
    {
        private readonly IUnbaser unbaser;

        public Destringifier(IUnbaser unbaser)
        {
            this.unbaser = unbaser;
        }

        public T Destringify<T>(string obj) where T : class
        {
            string json = this.unbaser.Unbase(obj);

            T instance = JsonConvert.DeserializeObject<T>(json);

            return instance;
        }
    }
}
