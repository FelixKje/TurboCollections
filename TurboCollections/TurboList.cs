using System;
using System.ComponentModel;

namespace TurboCollections{
    public class TurboList<T>{

        
        public int Count => items.Length;
        
        T[] items = Array.Empty<T>();
        
        public  void Add(T item){
            T[] newArray = new T[Count + 1];
            for (int i = 0; i < Count; i++){
                newArray[i] = items[i];
            }
            
            newArray[Count] = item;
            
            items = newArray;
        }

        public T Get(int index){
            return items[index];
        }

        public void Clear(){
            items = Array.Empty<T>();
        }
        
        // removes one item from the list. If the 4th item is removed, then the 5th item becomes the 4th, the 6th becomes the 5th and so on.
        public void RemoveAt(int index){
            T[] newArray = new T[Count - 1];
            for (int i = 0; i < Count-1; i++){
                if (i >= index)
                    newArray[i] = items[i+1]; 
                newArray[i] = items[i];
            }
            items = newArray;
        }

        public bool Contains(T item){
            foreach (var t in items){
                if (item.Equals(t)){
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(T item){
            for (int i = 0; i < items.Length; i++){
                if (item.Equals(items[i])){
                    return i;
                }
            }
            return -1;
        }

        public void Remove(T item){
            if (Contains(item)){
                RemoveAt(IndexOf(item));
            }
        }
    }
}