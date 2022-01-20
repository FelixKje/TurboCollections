

namespace TurboCollections{
    public class TurboQueue<T>{
        public int Count{ get; private set; }

        T[] items = System.Array.Empty<T>();

        public  void Enqueue(T item){
            EnsureSize(Count + 1);
            items[Count++] = item;
        }

        void EnsureSize(int size){
            if (size <= 0)
                return;

            T[] newArray = new T[size];
            for (int i = 0; i < Count; i++){
                newArray[i] = items[i];
            }
            items = newArray;
        }
        
        public T Peek(){
            return items[0];
        }
        
        public T Dequeue(){
            var item = Peek();
            return item;
        }
    }
}