using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Main
{
    public static class Convertir
    {
        public static List<List<string>> ListListString(DataTable dataTable)
        {
            if (dataTable is null)
            {
                return null;
            }
            else if (dataTable.Rows.Count == 0)
            {
                return new List<List<string>>();
            }
            else
            {
                List<List<string>> listListString = new List<List<string>>();
                foreach (DataRow row in dataTable.Rows)
                {
                    List<string> listString = new List<string>();
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        listString.Add(Convert.ToString(row[column.ColumnName]));
                    }
                    listListString.Add(listString);
                }
                return listListString;
            }
        }

        public static List<string> ListString(DataTable dataTable)
        {
            if (dataTable is null)
            {
                return null;
            }
            else if (dataTable.Rows.Count == 0)
            {
                return new List<string>();
            }
            else
            {
                List<string> listString = new List<string>();
                DataRow row = dataTable.Rows[0];
                foreach (DataColumn column in dataTable.Columns)
                {
                    listString.Add(Convert.ToString(row[column.ColumnName]));
                }
                return listString;
            }
        }

        public static List<int> ListInt(DataTable dataTable)
        {
            if (dataTable is null)
            {
                return null;
            }
            else if (dataTable.Rows.Count == 0)
            {
                return new List<int>();
            }
            else
            {
                List<int> listInt = new List<int>();
                DataColumn column = dataTable.Columns[0];
                foreach (DataRow row in dataTable.Rows)
                {
                    listInt.Add(Convert.ToInt32(row[column.ColumnName]));
                }
                return listInt;
            }
        }

        public static int Int(DataTable dataTable)
        {
            if (dataTable is null)
            {
                return -1;
            }
            else if (dataTable.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                DataRow row = dataTable.Rows[0];
                return Convert.ToInt32(row[0]);
            }
        }

        public static decimal Decimal(DataTable dataTable)
        {
            if (dataTable is null)
            {
                return -1;
            }
            else if (dataTable.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                DataRow row = dataTable.Rows[0];
                return Convert.ToDecimal(row[0]);
            }
        }
    }
}
