using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue and dequeue single item
    // Expected Result:  Successfully dequeues the single item
    // Defect(s) Found:  None
    public void TestPriorityQueue_SingleItem()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A",1);
        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with different priorities.
    // Expected Result: Items are dequeued in order of highest priority.
    // Defect(s) Found: None
    public void TestPriorityQueue_MultiplePriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);


        Assert.AreEqual("B", priorityQueue.Dequeue()); //highest priority first
        Assert.AreEqual("C", priorityQueue.Dequeue()); //next highest priority
        Assert.AreEqual("A", priorityQueue.Dequeue()); //lowest priority last
    }

    [TestMethod]
   //Scenario: Enqueue Multiple items with the same priority.
   //Expected Result: Items with the same priority are dequeued in FIFO.
   //Defects Found: None
   public void TestPriorityQueue_SamePriority()
   {
    var priorityQueue = new PriorityQueue();
    priorityQueue.Enqueue("A", 2);
    priorityQueue.Enqueue("B", 2);
    priorityQueue.Enqueue("C", 2);

    Assert.AreEqual("A", priorityQueue.Dequeue());
    Assert.AreEqual("B", priorityQueue.Dequeue());
    Assert.AreEqual("C", priorityQueue.Dequeue());
   }

   [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: Throws an InvalidOperationException.
    // Defect(s) Found: None.
    public void TestPriorityQueue_Empty(){
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}