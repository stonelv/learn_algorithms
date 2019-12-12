using cmd_algorithms;
using cmd_algorithms.data_structures;
using NUnit.Framework;

namespace cmd_algorithms_test
{
    [TestFixture]    
    public class LinkedList_Test
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void should_return_default_head_when_create_int_linkedList()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            Assert.IsNotNull(linkedList.Head);
            Assert.AreEqual(linkedList.Head.Value, 0);
        }

        [Test]
        public void should_return_default_head_when_create_string_linkedList()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            Assert.IsNotNull(linkedList.Head);
            Assert.AreEqual(linkedList.Head.Value, null);
        }

        [Test]
        public void should_return_the_node_with_int_value_if_exists()
        {
            LinkedList<int> linkedList = new LinkedList<int>(1);
            Assert.AreEqual(linkedList.Find(1).Value, 1);
            Assert.IsNull(linkedList.Find(2));
        }

        [Test]
        public void should_return_the_node_with_string_value_if_exists()
        {
            LinkedList<string> linkedList = new LinkedList<string>("test");
            Assert.AreEqual(linkedList.Find("test").Value, "test");
            Assert.IsNull(linkedList.Find("test"));
        }

        [Test]
        public void should_can_insert_int_node_with_position()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.Insert(1, 1); //add 1 at position 1
            Assert.AreEqual(linkedList.Find(1).Value, 1);
        }

        [Test]
        public void should_can_insert_string_node_with_position()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.Insert(1, "test"); //add "test" at position 1
            Assert.AreEqual(linkedList.Find("test").Value, "test");
            Assert.AreEqual(linkedList.Find(1).Value, "test");
        }

    }
}
