using Xunit;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Algorithms.ArraysAndStrings;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class ParseAndTablefyTest
    {
        [Fact]
        public void Parse_And_Tablefy_A_Simple_Json()
        {
            string json = @"[
                               {
                                  'account':'abc123',
                                  'date':'2020-11-06T00:00:00Z',
                                  'transactions':
                                  [
                                     {
                                        'value':45
                                     },
                                     {
                                        'value':10
                                     },
                                     {
                                        'value':22
                                     },
                                     {
                                        'value':43
                                     }
                                  ],
                                  'information':
                                  {
                                     'name':'ABC DEF',
                                     'age':33
                                  }
                               }
                            ]";

            JToken parsedValue = JsonConvert.DeserializeObject(json, new JsonSerializerSettings
            {
                DateParseHandling = DateParseHandling.None
            }) as JToken;

            var (result, stringResult) = new ParseAndTablefy().Execute(parsedValue.Root);

            Assert.Equal(5, result.Count);
            Assert.Equal("abc123", result["root.account"][0]);
            Assert.Equal("2020-11-06T00:00:00Z", result["root.date"][0]);
            Assert.Equal("ABC DEF", result["root.information.name"][0]);
            Assert.Equal((long)33, result["root.information.age"][0]);

            Assert.Equal((long)45, result["root.transactions.value"][0]);
            Assert.Equal((long)10, result["root.transactions.value"][1]);
            Assert.Equal((long)22, result["root.transactions.value"][2]);
            Assert.Equal((long)43, result["root.transactions.value"][3]);

            Assert.Equal(@"root.account | root.date | root.transactions.value | root.information.name | root.information.age | 
------------------------------------------------------------------------------------------------------
abc123 | 2020-11-06T00:00:00Z | 45 | ABC DEF | 33 | 
abc123 | 2020-11-06T00:00:00Z | 10 | ABC DEF | 33 | 
abc123 | 2020-11-06T00:00:00Z | 22 | ABC DEF | 33 | 
abc123 | 2020-11-06T00:00:00Z | 43 | ABC DEF | 33 | 
", stringResult);
        }
    }
}