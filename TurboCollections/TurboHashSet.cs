using System;
using System.Collections.Generic;

namespace TurboCollections{
    
    public class TurboHashSet<T>{
        
        static readonly int[] s_primes =
        {
            3, 7, 11, 17, 23, 29, 37, 47, 59, 71, 89, 107, 131, 163, 197, 239, 293, 353, 431, 521, 631, 761, 919,
            1103, 1327, 1597, 1931, 2333, 2801, 3371, 4049, 4861, 5839, 7013, 8419, 10103, 12143, 14591,
            17519, 21023, 25229, 30293, 36353, 43627, 52361, 62851, 75431, 90523, 108631, 130363, 156437,
            187751, 225307, 270371, 324449, 389357, 467237, 560689, 672827, 807403, 968897, 1162687, 1395263,
            1674319, 2009191, 2411033, 2893249, 3471899, 4166287, 4999559, 5999471, 7199369
        };

        static HashSet<string> names = new HashSet<string>();
        public static int Next{ get; private set; }
        
        public int Count{ get; private set; }
        T[] buckets = Array.Empty<T>();

        int nextPrimeIndex;

        void start(){
            Next = -1;
        }

        public bool Insert(T item){
            Resize(Count + 1);
            var hash = Hash(item);
            if (item.Equals(buckets[hash]))
                return false;
            if (buckets[hash] != null){
                Next = hash + 1;
                buckets[Next] = item;
                return true;
            }
            buckets[hash] = item;
            return true;
    }

        int Hash(T item){
            var hash = item.GetHashCode();
            hash %= buckets.Length;
            return hash;
        }

        void Resize(int size){
            if (buckets.Length >= size + size * 0.7f)
                return;
            nextPrimeIndex++;
            
            int newSize = s_primes[nextPrimeIndex];
            
            T[] newArray = new T[newSize];
            for (int i = 0; i < buckets.Length; i++){
                newArray[i] = buckets[i];
            }
            buckets = newArray;
        }
        bool Exists(T item){
            var hash = Hash(item);
            if(item.Equals(buckets[hash])) 
                return true;
            return false;
        }
        bool Remove(T item){
            return false;
        }
        
    }
}