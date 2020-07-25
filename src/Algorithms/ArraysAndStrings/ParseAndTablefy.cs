using System.Text;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Algorithms.ArraysAndStrings
{
    public class ParseAndTablefy
    {
        public (Dictionary<string, List<object>>, string) Execute(JToken currentObject)
        {
            var columnsIndex = new Dictionary<string, int>();
            var columnsAndRows = new Dictionary<string, List<object>>();

            int maxRowLength = 0;
            parse(currentObject, columnsIndex, columnsAndRows, "root", ref maxRowLength);

            var stringResult = tablefy(columnsAndRows, maxRowLength);

            return (columnsAndRows, stringResult);
        }

        private void parse(JToken currentObject, Dictionary<string, int> columnsIndex, Dictionary<string, List<object>> columnsAndRows, string parentElementName, ref int maxRowLength)
        {
            if (currentObject == null)
            {
                return;
            }
            else if (currentObject.Type == JTokenType.Array || currentObject.Type == JTokenType.Object)
            {
                foreach (var child in currentObject.Children())
                {
                    parse(child, columnsIndex, columnsAndRows, parentElementName, ref maxRowLength);
                }
            }
            else if (currentObject.Type == JTokenType.Property)
            {
                JProperty property = currentObject as JProperty;
                string propName = $"{parentElementName}.{property.Name}";
                parse(property.Value, columnsIndex, columnsAndRows, propName, ref maxRowLength);
            }
            else if (currentObject is JValue)
            {
                JValue value = currentObject as JValue;

                if (!columnsAndRows.ContainsKey(parentElementName))
                {
                    columnsAndRows.Add(parentElementName, new List<object>() { value.Value });
                    columnsIndex.Add(parentElementName, columnsIndex.Count);
                }
                else
                {
                    columnsAndRows[parentElementName].Add(value.Value);
                }

                if (maxRowLength < columnsAndRows[parentElementName].Count)
                {
                    maxRowLength = columnsAndRows[parentElementName].Count;
                }

                correctNumberOfRowsInPastColumns(columnsIndex, columnsAndRows, parentElementName, maxRowLength);
            }
        }

        private void correctNumberOfRowsInPastColumns(Dictionary<string, int> columnsIndex, Dictionary<string, List<object>> columnsAndRows, string currentElementName, int maxRowLength)
        {
            int currentColumnIndex = columnsIndex[currentElementName];

            foreach (var item in columnsAndRows)
            {
                if (columnsIndex[item.Key] <= currentColumnIndex)
                {
                    while (item.Value.Count < maxRowLength)
                    {
                        item.Value.Add(item.Value[item.Value.Count - 1]);
                    }
                }
            }
        }

        private string tablefy(Dictionary<string, List<object>> columnsAndRows, int maxRowLength)
        {
            StringBuilder sb = new StringBuilder();

            //Print Header
            int columnIndex = 0;
            foreach (var item in columnsAndRows)
            {
                sb.Append(item.Key);
                if (columnIndex < columnsAndRows.Count - 1)
                {
                    sb.Append(" | ");
                }
                columnIndex++;
            }

            string division = new string('-', sb.Length);
            sb.AppendLine();
            sb.AppendLine(division);

            //Print Rows
            for (int rowIndex = 0; rowIndex < maxRowLength; rowIndex++)
            {
                columnIndex = 0;
                foreach (var item in columnsAndRows)
                {
                    if (rowIndex >= item.Value.Count)
                    {
                        sb.Append(item.Value[item.Value.Count - 1]);
                    }
                    else
                    {
                        sb.Append(item.Value[rowIndex]);
                    }

                    if (columnIndex < columnsAndRows.Count - 1)
                    {
                        sb.Append(" | ");
                        columnIndex++;
                    }
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}