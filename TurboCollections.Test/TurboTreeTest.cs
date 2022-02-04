using NUnit.Framework;

namespace TurboCollections.Test{
    public class TurboTreeTest{
        [Test]
        public void NewStackIsEmpty(){
            var tree = new TurboTree<int>();
            tree.Insert(6);
            tree.Insert(4);
            tree.Insert(8);
            tree.Insert(9);
            Assert.AreEqual(9, tree.Search(9));
        }
    }
}