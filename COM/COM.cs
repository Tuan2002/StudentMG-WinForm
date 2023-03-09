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
        public void AddData(string key, string value)
        {
            data.Add(key, value);
        }
        public void ClearData()
        {
            data.Clear();
        }
        public void addObjectData(Object obj)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(obj);
            foreach (PropertyDescriptor prop in properties)
            {
                data.Add(prop.Name, prop.GetValue(obj));
            }

        }
        public Object getObjectData(Object obj)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(obj);
            foreach (PropertyDescriptor prop in properties)
            {
                prop.SetValue(obj, data[prop.Name]);
            }
            return obj;
        }
        public string GetData(string key)
        {
            string value = (string)data[key];
            return value;
        }

    }
}
