using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priorities.
    // Expected Result: The item with the highest priority should be dequeued first.
    // Defect(s) Found: The original Dequeue loop did not check every item in the queue, so the last item could be ignored.
    public void TestPriorityQueue_HighestPriority()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 3);

        Assert.AreEqual("C", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add multiple items with the same highest priority.
    // Expected Result: When priorities are tied, the first item with that priority should be dequeued first.
    // Defect(s) Found: The original code selected the last matching priority instead of preserving FIFO order.
    public void TestPriorityQueue_SamePriorityUsesFIFO()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 3);

        Assert.AreEqual("A", priorityQueue.Dequeue());
        Assert.AreEqual("B", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue multiple items after adding them.
    // Expected Result: Each dequeued item should be removed from the queue.
    // Defect(s) Found: The original code returned the selected item but did not remove it from the queue.
    public void TestPriorityQueue_DequeueRemovesItem()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);

        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty priority queue.
    // Expected Result: InvalidOperationException should be thrown with the message "The queue is empty."
    // Defect(s) Found: No defect found after confirming the required exception type and message.
    public void TestPriorityQueue_EmptyQueueThrowsException()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
        Assert.AreEqual("The queue is empty.", exception.Message);
    }
}