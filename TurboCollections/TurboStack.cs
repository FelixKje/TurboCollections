﻿using System;

namespace TurboCollections{
    public class TurboStack<T>{
        // returns the current amount of items contained in the stack.
        public int Count => items.Length;

        T[] items = Array.Empty<T>();

        // adds one item on top of the stack.
        public void Push(T item){
            T[] newArray = new T[Count + 1];
            for (int i = 0; i < Count; i++){
                newArray[i] = items[i];
            }

            newArray[Count] = item;

            items = newArray;
        }
    }
}