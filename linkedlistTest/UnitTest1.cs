namespace linkedlistTest
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldReturnALinkedSinglyList()
        {
            // Arrange
            LinkedList<string> myList1 = new LinkedList<string>();
            LinkedList<string> myList2 = new LinkedList<string>();
            

            // Act
            /*myList1.AddFirst("a");
            myList1.AddFirst("b");
            myList1.AddFirst("c");

            myList2.AddLast("d");
            myList2.AddLast("e");
            myList2.AddLast("f");*/
            
            // Assert
            
            Assert.Equal("cars",myList1.AddFirst() );
            
        }
    }
}