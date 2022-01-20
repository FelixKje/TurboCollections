using System;

namespace TurboCollections{
    public class TurboQueue<T>{
        public int Count{ get; private set; }

        int start;

        T[] items = Array.Empty<T>();

        public void Enqueue(T item){
            EnsureSize(Count + 1);
            items[(Count + start) % items.Length] = item;
            Count++;
        }

        void EnsureSize(int size){
            if (items.Length >= size)
                return;
            
            int newSize = Math.Max(size, items.Length * 2);
            T[] newArray = new T[newSize];
            for (int i = 0; i < Count; i++){
                newArray[i] = items[i];
            }
            items = newArray;
        }

        public T Peek(){
            return items[start];
        }
        
        public T Dequeue(){
            var item = Peek();
            start++;
            start %= items.Length;
            Count--;
            return item;
        }

        public void Clear(){
            for (int i = 0; i < Count; i++){
                items[i] = default;
            }
            Count = 0;
        }
    }
}