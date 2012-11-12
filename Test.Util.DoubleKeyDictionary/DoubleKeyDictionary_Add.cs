using Microsoft.VisualStudio.TestTools.UnitTesting;
using Util.DoubleKeyDictionary;

namespace Test.Util.DoubleKeyDictionary
{
    [TestClass]
    public class DoubleKeyDictionary_Add
    {
        [TestMethod]
        public void Add_IntKeys_Works()
        {
            var dict = new DoubleKeyDictionary<int, int, int>();
            dict.Add(1, 1, 2);
            dict.Add(2, 2, 4);

            Assert.IsTrue(dict.ContainsKey(1, 1));
            Assert.IsTrue(dict.ContainsKey(2, 2));
        }

        [TestMethod]
        public void Add_StringKeys_Works()
        {
            var dict = new DoubleKeyDictionary<string, string, int>();
            dict.Add("1", "1", 2);
            dict.Add("2", "2", 4);

            Assert.IsTrue(dict.ContainsKey("1", "1"));
            Assert.IsTrue(dict.ContainsKey("2", "2"));
        }

        [TestMethod]
        public void Add_StringAndIntKeys_Works()
        {
            var dict = new DoubleKeyDictionary<string, int, int>();
            dict.Add("1", 1, 2);
            dict.Add("2", 2, 4);

            Assert.IsTrue(dict.ContainsKey("1", 1));
            Assert.IsTrue(dict.ContainsKey("2", 2));
        }

        [TestMethod]
        public void Add_SameKeys_Allowed()
        {
            var dict = new DoubleKeyDictionary<string, string, int>();
            dict.Add("1", "1", 2);
            dict.Add("1", "1", 4);

            Assert.IsTrue(dict.ContainsKey("1", "1"));
        }

        [TestMethod]
        public void Add_SameKeys_UpdatesValue()
        {
            var dict = new DoubleKeyDictionary<string, string, int>();
            
            // add first value
            dict.Add("1", "1", 2);
            var val = dict["1", "1"];
            // assert value is 2
            Assert.AreEqual<int>(2, val);

            // update value
            dict.Add("1", "1", 4);
            val = dict["1", "1"];
            // assert value has been updated to 4
            Assert.AreEqual<int>(4, val);
        }
    }
}
