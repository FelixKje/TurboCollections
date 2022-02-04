using System;


namespace TurboCollections{
    public class Node{
        public Node LeftNode{ get; set; }
        public Node RightNode{ get; set; }
        public int Data{ get; set; }
    }
    public class TurboTree<T>{
        
        public Node Root{ get; set; }
        T[] tree = Array.Empty<T>();

        public void Insert(int value){
            var node = Root;
            var insertComplete = false;
            while (insertComplete == false){
                if (node == null){
                    Root.Data = value;
                    insertComplete = true;
                }
                if (value > node.Data){
                    if (node.RightNode == null) 
                        node.RightNode.Data = value;
                    node = node.RightNode;
                }
                else{
                    if (node.LeftNode == null)
                        node.LeftNode.Data = value;
                    node = node.LeftNode;
                }
            }
        }

        public Node Search(int value){
            var node = Root;
            if (node != null){
                while (node.Data != value){
                    if (node.Data == value) return node;
                    if (node.Data > value)
                        node = node.RightNode;
                    else{
                        node = node.LeftNode;
                    }
                }
                return null;
            }
            return null;
        }

        public void Delete(){
            
        }
    }
    
}