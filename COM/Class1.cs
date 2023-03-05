using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM
{
    public class Request
    {
        ListDictionary data = new ListDictionary();
        public void AddData (string key, string value)
        {
            data.Add (key, value);
        }
       public string GetData (string key)
        {
            string value = (string)data[key];
            return value;
        }

    }
    public class Response: Request
    {
        public string status;
     
    }
}
