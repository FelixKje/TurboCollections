using System;

namespace TurboCollections{
    public class TurboQueue<T>{
        public int Count{ get; private set; }

        public int nextInQueue;

        T[] items = Array.Empty<T>();

        public  void Enqueue(T item){
            EnsureSize(Count + 1);
            items[Count++] = item;
        }

        void EnsureSize(int size){
            if (items.Length >= size)
                return;
            
            int newSize = Math.Max(size, items.Length * 2);
            
            T[] newArray = new T[newSize];
            for (int i = 0; i < Count; i++){
                newArray[nextInQueue++] = items[i];
                if (nextInQueue == 10)
                    nextInQueue = 0;
            }
            nextInQueue = 0;
            items = newArray;
        }

        void OrganizeQueue(){
            EnsureSize(items.Length);
            nextInQueue = 0;
        }
        
        public T Peek(){
            return items[nextInQueue];
        }
        
        public T Dequeue(){
            var item = Peek();
            nextInQueue++;
            if (nextInQueue == 10){
                OrganizeQueue();
            }
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