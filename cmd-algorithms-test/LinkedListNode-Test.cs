
using cmd_algorithms;
using NUnit.Framework;

namespace cmd_algorithms_test
{
    [TestFixture]
    public class LinkedListNode_Test
    {
        [Test]
        public void should_create_node_with_int_value()
        {
            var linkedListNode = new LinkedListNode<int>(1);
            Assert.AreEqual(linkedListNode.Value, 1);
            Assert.IsNull(linkedListNode.Next);
        }

        [Test]
        public void should_create_node_with_string_value()
        {
            var linkedListNode = new LinkedListNode<string>("test");
            Assert.AreEqual(linkedListNode.Value, "test");
            Assert.IsNull(linkedListNode.Next);
        }
    }
}
