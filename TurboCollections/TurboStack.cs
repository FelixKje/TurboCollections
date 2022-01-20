

namespace TurboCollections{
    public class TurboStack<T>{
        public int Count{ get; private set; }

        T[] items = System.Array.Empty<T>();
        
        public  void Push(T item){
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
            return items[Count - 1];
        }

        public T Yeet(){
            var item = Peek();
            EnsureSize(Count--);
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