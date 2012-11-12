using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Util.DoubleKeyDictionary;

namespace Test.Util.DoubleKeyDictionary
{
    [TestClass]
    public class DoubleKeyDictionary_Equals
    {
        [TestMethod]
        public void Equals_IntKeys_DifferentKeys_NotEqual()
        {
            var dict1 = new DoubleKeyDictionary<int, int, int>();
            var dict2 = new DoubleKeyDictionary<int, int, int>();

            dict1.Add(1, 1, 2);
            dict1.Add(2, 1, 3);
            dict2.Add(1, 1, 2);

            Assert.IsFalse(dict1.Equals(dict2));
        }

        [TestMethod]
        public void Equals_IntKeys_OneValue_DifferentKey2_NotEqual()
        {
            var dict1 = new DoubleKeyDictionary<int, int, int>();
            var dict2 = new DoubleKeyDictionary<int, int, int>();

            dict1.Add(1, 1, 2);
            dict2.Add(1, 2, 2);

            Assert.IsFalse(dict1.Equals(dict2));
        }

        [TestMethod]
        public void Equals_IntKeys_DifferentKey1_NotEqual()
        {
            var dict1 = new DoubleKeyDictionary<int, int, int>();
            var dict2 = new DoubleKeyDictionary<int, int, int>();

            dict1.Add(1, 2, 2);
            dict2.Add(2, 2, 3);

            Assert.IsFalse(dict1.Equals(dict2));
        }


        [TestMethod]
        public void Equals_IntKeys_OneValue_AreEqual()
        {
            var dict1 = new DoubleKeyDictionary<int, int, int>();
            var dict2 = new DoubleKeyDictionary<int, int, int>();

            dict1.Add(1, 1, 2);
            dict2.Add(1, 1, 2);

            Assert.IsTrue(dict1.Equals(dict2));
        }

        [TestMethod]
        public void Equals_StringKeys_OneValue_AreEqual()
        {
            var dict1 = new DoubleKeyDictionary<string, string, int>();
            var dict2 = new DoubleKeyDictionary<string, string, int>();

            dict1.Add("1", "1", 2);
            dict2.Add("1", "1", 2);

            Assert.IsTrue(dict1.Equals(dict2));
        }

        [TestMethod]
        public void Equals_StringKeys_SameKeys_DifferentValue_NotEqual()
        {
            var dict1 = new DoubleKeyDictionary<string, string, int>();
            var dict2 = new DoubleKeyDictionary<string, string, int>();

            dict1.Add("1", "1", 3);
            dict2.Add("1", "1", 2);

            Assert.IsFalse(dict1.Equals(dict2));
        }

        [TestMethod]
        public void Equals_DifferentKeyTypes_SameValue_NotEqual()
        {
            var dict1 = new DoubleKeyDictionary<int, string, int>();
            var dict2 = new DoubleKeyDictionary<string, string, int>();

            dict1.Add(1, "1", 2);
            dict2.Add("1", "1", 2);

            Assert.IsFalse(dict1.Equals(dict2));
        }

        [TestMethod]
        public void Equals_StringKeys_MultipleValues_NotEqual()
        {
            var dict1 = new DoubleKeyDictionary<string, string, int>();
            var dict2 = new DoubleKeyDictionary<string, string, int>();

            dict1.Add("1", "1", 2);
            dict1.Add("1", "2", 3);
            dict2.Add("1", "1", 2);

            Assert.IsFalse(dict1.Equals(dict2));
        }

        [TestMethod]
        public void Equals_IntKeys_MultipleValues_NotEqual()
        {
            var dict1 = new DoubleKeyDictionary<int, int, int>();
            var dict2 = new DoubleKeyDictionary<int, int, int>();

            dict1.Add(1, 1, 2);
            dict1.Add(1, 2, 3);
            dict2.Add(1, 1, 2);

            Assert.IsFalse(dict1.Equals(dict2));
        }
    }
}
