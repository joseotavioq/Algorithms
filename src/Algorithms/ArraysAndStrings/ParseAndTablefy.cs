using System.Text;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Algorithms.ArraysAndStrings
{
    public class ParseAndTablefy
    {
        public (Dictionary<string, List<object>>, string) Execute(JToken currentObject)
        {
            var elementsParsed = new Dictionary<string, List<object>>();

            parse(currentObject, elementsParsed, "root");

            var stringResult = tablefy(elementsParsed);

            return (elementsParsed, stringResult);
        }

        private void parse(JToken currentObject, Dictionary<string, List<object>> elementsParsed, string parentElementName)
        {
            if (currentObject == null)
            {
                return;
            }
            else if (currentObject.Type == JTokenType.Array || currentObject.Type == JTokenType.Object)
            {
                foreach (var child in currentObject.Children())
                {
                    parse(child, elementsParsed, parentElementName);
                }
            }
            else if (currentObject.Type == JTokenType.Property)
            {
                JProperty property = currentObject as JProperty;
                string propName = $"{parentElementName}.{property.Name}";
                parse(property.Value, elementsParsed, propName);
            }
            else
            {
                JValue value = currentObject as JValue;

                if (!elementsParsed.ContainsKey(parentElementName))
                {
                    elementsParsed.Add(parentElementName, new List<object>() { value.Value });
                }
                else
                {
                    elementsParsed[parentElementName].Add(value.Value);
                }

                correctNumberOfRowsInPastColumns(elementsParsed, parentElementName);
            }
        }

        private void correctNumberOfRowsInPastColumns(Dictionary<string, List<object>> elementsParsed, string currentElementName)
        {
            int maxRowLength = getMaxRowLength(elementsParsed);

            foreach (var item in elementsParsed)
            {
                while (item.Value.Count < maxRowLength)
                {
                    item.Value.Add(item.Value[item.Value.Count - 1]);
                }

                if (item.Key == currentElementName)
                {
                    break;
                }
            }
        }

        private string tablefy(Dictionary<string, List<object>> elementsParsed)
        {
            StringBuilder sb = new StringBuilder();

            //Print Header
            int columnIndex = 0;
            foreach (var item in elementsParsed)
            {
                sb.Append(item.Key);
                if (columnIndex < elementsParsed.Count - 1)
                {
                    sb.Append(" | ");
                }
                columnIndex++;
            }

            string division = new string('-', sb.Length);
            sb.AppendLine();
            sb.AppendLine(division);

            //Print Rows
            int rowsLength = getMaxRowLength(elementsParsed);

            for (int rowIndex = 0; rowIndex < rowsLength; rowIndex++)
            {
                columnIndex = 0;
                foreach (var item in elementsParsed)
                {
                    if (rowIndex >= item.Value.Count)
                    {
                        sb.Append(item.Value[item.Value.Count - 1]);
                    }
                    else
                    {
                        sb.Append(item.Value[rowIndex]);
                    }

                    if (columnIndex < elementsParsed.Count - 1)
                    {
                        sb.Append(" | ");
                        columnIndex++;
                    }
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }

        private int getMaxRowLength(Dictionary<string, List<object>> elementsParsed)
        {
            int max = 0;

            foreach (var item in elementsParsed)
            {
                if (item.Value.Count > max)
                {
                    max = item.Value.Count;
                }
            }

            return max;
        }
    }
}