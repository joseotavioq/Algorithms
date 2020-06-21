using Xunit;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Algorithms.ArraysAndStrings;

namespace AlgorithmsTest.ArraysAndStrings
{
    public class ParseAndTablefyTest
    {
        private string NEWLINE = System.Environment.NewLine;

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

            for (int i = 0; i < 4; i++)
            {
                Assert.Equal("abc123", result["root.account"][i]);
                Assert.Equal("2020-11-06T00:00:00Z", result["root.date"][i]);
                Assert.Equal("ABC DEF", result["root.information.name"][i]);
                Assert.Equal((long)33, result["root.information.age"][i]);
            }

            Assert.Equal((long)45, result["root.transactions.value"][0]);
            Assert.Equal((long)10, result["root.transactions.value"][1]);
            Assert.Equal((long)22, result["root.transactions.value"][2]);
            Assert.Equal((long)43, result["root.transactions.value"][3]);

            var expectedResult = $"root.account | root.date | root.transactions.value | root.information.name | root.information.age{NEWLINE}-------------------------------------------------------------------------------------------------{NEWLINE}abc123 | 2020-11-06T00:00:00Z | 45 | ABC DEF | 33{NEWLINE}abc123 | 2020-11-06T00:00:00Z | 10 | ABC DEF | 33{NEWLINE}abc123 | 2020-11-06T00:00:00Z | 22 | ABC DEF | 33{NEWLINE}abc123 | 2020-11-06T00:00:00Z | 43 | ABC DEF | 33{NEWLINE}";
            Assert.Equal(expectedResult, stringResult);
        }

        [Fact]
        public void Parse_And_Tablefy_A_Json_With_Two_Elements_In_Root_Node()
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
                               },
                               {
                                  'account':'xyz456',
                                  'date':'2020-12-10T00:00:00Z',
                                  'transactions':
                                  [
                                     {
                                        'value':1
                                     },
                                     {
                                        'value':2
                                     },
                                     {
                                        'value':3
                                     },
                                     {
                                        'value':4
                                     }
                                  ],
                                  'information':
                                  {
                                     'name':'XYZ GHI',
                                     'age':28
                                  }
                               }
                            ]";

            JToken parsedValue = JsonConvert.DeserializeObject(json, new JsonSerializerSettings
            {
                DateParseHandling = DateParseHandling.None
            }) as JToken;

            var (result, stringResult) = new ParseAndTablefy().Execute(parsedValue.Root);

            Assert.Equal(5, result.Count);

            for (int i = 0; i < 4; i++)
            {
                Assert.Equal("abc123", result["root.account"][i]);
                Assert.Equal("2020-11-06T00:00:00Z", result["root.date"][i]);
                Assert.Equal("ABC DEF", result["root.information.name"][i]);
                Assert.Equal((long)33, result["root.information.age"][i]);
            }

            Assert.Equal((long)45, result["root.transactions.value"][0]);
            Assert.Equal((long)10, result["root.transactions.value"][1]);
            Assert.Equal((long)22, result["root.transactions.value"][2]);
            Assert.Equal((long)43, result["root.transactions.value"][3]);

            for (int i = 4; i < 8; i++)
            {
                Assert.Equal("xyz456", result["root.account"][i]);
                Assert.Equal("2020-12-10T00:00:00Z", result["root.date"][i]);
                Assert.Equal("XYZ GHI", result["root.information.name"][i]);
                Assert.Equal((long)28, result["root.information.age"][i]);
            }

            Assert.Equal((long)1, result["root.transactions.value"][4]);
            Assert.Equal((long)2, result["root.transactions.value"][5]);
            Assert.Equal((long)3, result["root.transactions.value"][6]);
            Assert.Equal((long)4, result["root.transactions.value"][7]);

            var expectedResult = $"root.account | root.date | root.transactions.value | root.information.name | root.information.age{NEWLINE}-------------------------------------------------------------------------------------------------{NEWLINE}abc123 | 2020-11-06T00:00:00Z | 45 | ABC DEF | 33{NEWLINE}abc123 | 2020-11-06T00:00:00Z | 10 | ABC DEF | 33{ NEWLINE}abc123 | 2020-11-06T00:00:00Z | 22 | ABC DEF | 33{ NEWLINE}abc123 | 2020-11-06T00:00:00Z | 43 | ABC DEF | 33{NEWLINE}xyz456 | 2020-12-10T00:00:00Z | 1 | XYZ GHI | 28{NEWLINE}xyz456 | 2020-12-10T00:00:00Z | 2 | XYZ GHI | 28{NEWLINE}xyz456 | 2020-12-10T00:00:00Z | 3 | XYZ GHI | 28{ NEWLINE}xyz456 | 2020-12-10T00:00:00Z | 4 | XYZ GHI | 28{ NEWLINE}";
            Assert.Equal(expectedResult, stringResult);
        }
    }
}