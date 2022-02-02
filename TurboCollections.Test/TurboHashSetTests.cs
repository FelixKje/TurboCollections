using System;
using NUnit.Framework;

namespace TurboCollections.Test{
    public class TurboHashSetTests{
        public class Insert{
            static TurboHashSet<string> GiveUnordered(){
                var bucket = new TurboHashSet<String>();
                bucket.Insert("Felix");
                bucket.Insert("Kent");
                bucket.Insert("Bengt");
                bucket.Insert("Arne");
                bucket.Insert("Gertrud");
                return bucket;
            }

            [Test]
            public void CheckBucketIfPeopleExists(){
                var bucket = GiveUnordered();
                Assert.IsTrue(bucket.Exists("Felix"));
                Assert.IsTrue(bucket.Exists("Kent"));
                Assert.IsTrue(bucket.Exists("Arne"));
            }
        }
    }
}