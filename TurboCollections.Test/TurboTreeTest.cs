using NUnit.Framework;

namespace TurboCollections.Test{
    public class TurboTreeTest{
        [Test]
        public void NewStackIsEmpty(){
            var tree = new TurboTree();
            Assert.Zero(0);
        }
    }
}