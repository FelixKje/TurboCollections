﻿using NUnit.Framework;

namespace TurboCollections.Test{
    public class TurboStackTest{
        [Test]
        public void NewStackIsEmpty(){
            var stack = new TurboStack<int>();
            Assert.Zero(stack.Count);
        }
        [Test]
        public void CreateNewStackAndCheckLength(){
            var stack = new TurboStack<int>();
            stack.Push(4);
            stack.Push(3);
            stack.Push(4);
            stack.Push(3);
            
            Assert.AreEqual(4,stack.Count);
        }
        [Test]
        public void PeekAtLastAddedStackItem(){
            var stack = new TurboStack<int>();
            stack.Push(4);
            stack.Push(3);
            stack.Push(4);
            stack.Push(78);
            
            Assert.AreEqual(78, stack.Peek());
        }
        [Test]
        public void ReturnLastItemThenYeetIt(){
            var stack = new TurboStack<int>();
            stack.Push(4);
            stack.Push(3);
            stack.Push(4);
            stack.Push(78);

            Assert.AreEqual(78, stack.Yeet());
            Assert.AreEqual(3, stack.Count);
        }
        [Test]
        public void MakeAStackThenClearItThenCheckIfEmpty(){
            var stack = new TurboStack<int>();
            stack.Push(4);
            stack.Push(3);
            stack.Push(4);
            stack.Push(78);
            stack.Clear();
            
            Assert.AreEqual(0, stack.Count);
        }
    }
}