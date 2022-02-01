using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TurboCollections{
    public class Node{
        public Node LeftNode{ get; set; }
        public Node RightNode{ get; set; }
        public int Data{ get; set; }
    }
    public class TurboTree{
        
        public Node Root{ get; set; }

        public void Insert(int value){
            var node = Root;
            if (node == null){
                Root.Data = value;
            }
            if (value > node.Data){
                if (node.RightNode == null) node.RightNode.Data = value;
                node = node.RightNode;
            }
            else{
                if (node.LeftNode == null) node.LeftNode.Data = value;
                node = node.LeftNode;
            }
        }

        public Node Search(int value, Node node){
            if (node != null){
                if (value == node.Data) return node;
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