using System.Collections;
using NUnit.Framework;

namespace TurboCollections.Test{
    public class TurboQueueTest{
        [Test]
        public void NewStackIsEmpty(){
            var stack = new TurboQueue<int>();
            Assert.Zero(stack.Count);
        }
        [Test]
        public void EnqueueAndCheckQueLength(){
            var list = new TurboQueue<int>();
            list.Enqueue(4);
            list.Enqueue(2);

            
            Assert.AreEqual(2 , list.Count);
        }
        
        [Test]
        public void EnqueueAndPeekTheFirstItemInQueue(){
            var list = new TurboQueue<int>();
            list.Enqueue(4);
            list.Enqueue(2);


            Assert.AreEqual(4 , list.Peek());
        }
        [Test]
        public void EnqueueAndDequeueTheFirstItemInQueue(){
            var list = new TurboQueue<int>();
            list.Enqueue(4);
            list.Enqueue(2);


            Assert.AreEqual(4 , list.Dequeue());
        }
        
        static (int[] numbers, TurboQueue<int>) CreateTestData()
        {
            int[] numbers = { 5, 7, -12, 9, 3, -4, 104, 12 };
            var list = new TurboQueue<int>();
            foreach(var number in numbers)
                list.Enqueue(number);

            return (numbers, list);
        }
    }
}