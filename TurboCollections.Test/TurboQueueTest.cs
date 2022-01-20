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
            Assert.AreEqual(numbers.Length , list.Count);
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