using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Util.DoubleKeyDictionary;
using System.Collections;

namespace Test.Util.DoubleKeyDictionary
{
    [TestClass]
    public class DoubleKeyDictionary_Enumerate
    {
        #region Test Setup
        DoubleKeyDictionary<int, int, int> dict;

        [TestInitialize]
        public void ResetDictionary()
        {
            dict = new DoubleKeyDictionary<int, int, int>();
            dict.Add(1, 1, 2);
            dict.Add(2, 1, 3);
            dict.Add(3, 1, 4);
            dict.Add(1, 2, 3);
            dict.Add(1, 3, 4);
            dict.Add(1, 4, 5);
        }
        #endregion

        [TestMethod]
        public void Enumerate_IntKeys_ToString_Returns_Key1Key2Value()
        {
            var dict = new DoubleKeyDictionary<string, string, int>();
            dict.Add("a", "b", 1);

            foreach (var item in dict)
            {
                Assert.AreEqual<string>("a - b - 1", item.ToString());
            }
        
        }

        [TestMethod]
        public void IEnumerate_IntKeys_ToString_Returns_Key1Key2Value()
        {
            var dict = new DoubleKeyDictionary<string, string, int>();
            dict.Add("a", "b", 1);

            IEnumerable dictList = dict;

            foreach (var item in dictList)
            {
                Assert.AreEqual<string>("a - b - 1", item.ToString());
            }
        }

        [TestMethod]
        public void Enumerate_IntKeys_Works()
        {
            int i = 0;
            foreach (var item in dict)
            {
                i++;
                Assert.AreEqual(typeof(int), item.Value.GetType());
            }

            Assert.AreEqual<int>(i, 6);

        }
    }
}
