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
        public void DequeueTheFirstItemInQueue(){
            var list = new TurboQueue<int>();
            list.Enqueue(4);
            list.Enqueue(2);


            Assert.AreEqual(4 , list.Dequeue());
        }
        
        [Test]
        public void ClearQueueFromAllItems(){
            var list = new TurboQueue<int>();
            list.Enqueue(4);
            list.Enqueue(2);
            list.Enqueue(7);
            list.Enqueue(87);
            list.Enqueue(95);
            list.Enqueue(23);
            list.Clear();


            Assert.AreEqual(0 , list.Count);
        }
        [Test]
        public void DequeueAndCheckIfNextInQueue(){
            var list = new TurboQueue<int>();
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 , 10, 11, 12, 13 ,14 ,15 ,16, 10, 11, 12, 13 ,14 ,15 ,16};

            for (int i = 0; i < numbers.Length; i++){
                list.Enqueue(numbers[i]);
            }

            for (int i = 0; i < 11; i++){
                list.Dequeue();
            }
            Assert.AreEqual(11 , list.Peek());
        }

        [Test]

        public void CheckThatCountDecreasesWhenItemIsRemoved(){
            var queue = new TurboQueue<int>();
            queue.Enqueue(5);
            Assert.AreEqual(1, queue.Count);
            queue.Enqueue(3);
            Assert.AreEqual(2, queue.Count);
            queue.Dequeue();
            Assert.AreEqual(1, queue.Count);
        }
        [Test]

        public void CheckItemsAreAtRightIndex(){
            var queue = new TurboQueue<int>();
            queue.Enqueue(1); // 1
            queue.Enqueue(2); // 2
            queue.Enqueue(3); // 3
            queue.Enqueue(4); // 4
            Assert.AreEqual(1, queue.Dequeue()); // 3
            queue.Enqueue(5); // 4
            Assert.AreEqual(2, queue.Dequeue());// 3
            queue.Enqueue(6); // 4
            Assert.AreEqual(3, queue.Dequeue()); // 3
            Assert.AreEqual(4, queue.Dequeue()); // 2
            Assert.AreEqual(5, queue.Dequeue()); // 1
            queue.Enqueue(7); // 2
            queue.Enqueue(8); // 3
            queue.Enqueue(9); // 4
            Assert.AreEqual(6,queue.Dequeue()); // 3
            Assert.AreEqual(7,queue.Dequeue());// 2
            Assert.AreEqual(8,queue.Dequeue());// 1
            Assert.AreEqual(9,queue.Dequeue());// 0
        }
        [Test]

        public void CheckIfResizeArrayWorks(){
            var queue = new TurboQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            Assert.AreEqual(1,queue.Dequeue());
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Assert.AreEqual(2,queue.Dequeue());
            Assert.AreEqual(3,queue.Dequeue());
            Assert.AreEqual(4,queue.Dequeue());
            Assert.AreEqual(5,queue.Dequeue());
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