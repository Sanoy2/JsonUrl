using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlJson
{
    public class Unbaser : IUnbaser
    {
        public string Unbase(string obj)
        {
            byte[] byteArray = Convert.FromBase64String(obj);

            string jsonBack = Encoding.UTF8.GetString(byteArray);

            return jsonBack;
        }
    }
}
