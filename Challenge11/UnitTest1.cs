using Microsoft.VisualStudio.TestPlatform.TestHost;
using CodingChallenge10;
namespace Challenge11
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            [Fact]
             void Enqueue_ShouldAddElementToACreatedQueue()
            {
                Queue myQueue = new Queue();
                int expected = 7;
                myQueue.Enqueue(7);
                myQueue.Enqueue(9);

                int actual = myQueue.GetPeek();
                Assert.Equal(expected, actual);
            }

            [Fact]
             void Dequeue_ShouldRemoveElementFromQueue()
            {
                Queue myQueue = new Queue();
                int expected = 9;
                myQueue.Enqueue(7);
                myQueue.Enqueue(9);
                myQueue.DeQueue();
                int actual = myQueue.GetPeek();
                Assert.Equal(expected, actual);
            }
        }
    }
}