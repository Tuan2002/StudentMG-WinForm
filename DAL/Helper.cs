using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Helper
    {
        public static DataTable ToDataTable<T>(this IQueryable<T> query)
        {
            var dataTable = new DataTable();
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var propInfo in properties)
            {
                dataTable.Columns.Add(propInfo.Name, Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType);
            }

            foreach (var item in query)
            {
                var row = dataTable.NewRow();
                foreach (var propInfo in properties)
                {
                    row[propInfo.Name] = propInfo.GetValue(item);
                }
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
        public static DataTable ConvertSingleResultToDataTable<T>(ISingleResult<T> singleResult)
        {
            DataTable dataTable = new DataTable();

            // Add columns to the DataTable based on the properties of the entity type
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                dataTable.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
            }

            // Populate the DataTable with the results from the SingleResult<T>
            foreach (var item in singleResult)
            {
                var row = dataTable.NewRow();

                foreach (var property in properties)
                {
                    row[property.Name] = property.GetValue(item);
                }

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
    }
}
