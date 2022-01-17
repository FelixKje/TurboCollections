using System;
using NUnit.Framework;

namespace TurboCollections.Test{
    public class TurboListTests{
        [Test]
        public void NewLisIsEmpty(){
            var list = new TurboList<int>();
            Assert.Zero(list.Count);
        }

        [Test]
        public void AddingAnElementIncreasesCountToOne(){
            var list = new TurboList<int>();
            list.Add(5);
            Assert.AreEqual(1, list.Count);
        }
        
        [Test, TestCase(5), TestCase(7)]
        public void AddingMultipleElementsIncreasesTheCount(int numberOfElements){
            var list = new TurboList<int>();
            for (int i = 0; i < numberOfElements; i++){
                list.Add(5);
            }
            Assert.AreEqual(numberOfElements, list.Count);
        }

        [Test]
        public void AnAddedElementCanBeGet(){
            var list = new TurboList<int>();
            list.Add(1337);
            Assert.AreEqual(1337, list.Get(0));
        }
        
        [Test]
        public void ClearingTheListOfAll(){
            var list = new TurboList<int>();
            list.Add(5);
            list.Clear();
            
            Assert.AreEqual(0, list.Count);
        }
        
        [Test]
        public void RemoveAtIndexThenMoveBackAllAfter(){
            var list = new TurboList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(5);
            list.Add(5);
            list.RemoveAt(2);
            
            Assert.AreEqual(3 , list.Count);
        }
    }
}