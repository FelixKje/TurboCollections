using System;
using NUnit.Framework;

namespace TurboCollections.Test
{
    public class TurboSortTests{
        public class BubbleSort{
            static TurboList<int> GiveUnordered(){
                var list = new TurboList<int>();
                list.Add(0);
                list.Add(3);
                list.Add(-12);
                list.Add(2);
                list.Add(1000);
                list.Add(-300);
                return list;
            }

            [Test]
            public void OrdersAnUnorderedList(){
                var list = GiveUnordered();
                TurboSort.BubbleSort(list);
                CollectionAssert.IsOrdered(list);
            }
        }

        public class QuickSort{
            static TurboList<int> GiveUnordered(){
                var list = new TurboList<int>();
                list.Add(0);
                list.Add(3);
                list.Add(-12);
                list.Add(2);
                list.Add(1000);
                list.Add(-300);
                return list;
            }

            [Test]
            public void OrdersAnUnorderedList(){
                var list = GiveUnordered();
                TurboSort.QuickSort(list);
                CollectionAssert.IsOrdered(list);
            }
        }
    }
}