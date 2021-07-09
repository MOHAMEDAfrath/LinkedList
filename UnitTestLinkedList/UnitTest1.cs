using LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLinkedList
{
    
    [TestClass]
    public class UnitTest1
    {
        public LinkedListOperations lk;
        [TestInitialize]
        public void SetUp()
        {
            lk = new LinkedListOperations();
            
        }
        
        [TestMethod]
        public void TestSearchMethod()
        {
            int data = 30;
            string expected = "Found! " + 30;
            lk.InsertAtLast(40);
            lk.InsertAtLast(30);
            lk.InsertAtLast(70);
            string actual = lk.Search(data);
            Assert.AreEqual(expected, actual);
        }
    }
}
