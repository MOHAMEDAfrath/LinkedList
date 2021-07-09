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
        [TestMethod]
        public void TestInsertAtGivenPosition()
        {
            lk.InsertAtLast(40);
            lk.InsertAtLast(30);
            lk.InsertAtLast(70);
            int data = 40,key = 70;
            bool expected = true;
            bool actual = false;
            Node temp = lk.InsertAtSpecificPosition(key, data);
            while (temp != null)
            {
                if(temp.data == key && temp.next.data == data)
                {
                    actual = true;
                }
                temp = temp.next;
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
