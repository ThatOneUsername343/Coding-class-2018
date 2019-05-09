using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Trees
{
    class BinaryTree
    {
        private Node1 Root { get; set; }
        public int Height { get { return Root != null ? Root.Height : 0; } }
        public int Count { get { return Root != null ? CountRecursive(Root) : 0; } }

        private int CountRecursive(Node1 ThatOneNode)
        {
            throw new NotImplementedException();
        }
        public void Insert(char ThatOneChar)
        {
            if (Root == null)
            {
                Root = new Node1(ThatOneChar);
            }
            else
            {
                Insert(Root, ThatOneChar);
            }
        }

        private void Insert(Node1 ThatOneNode, char ThatOneChar)
        {
            if (ThatOneChar >= ThatOneNode.Value && ThatOneNode.RightChild == null)
            {
                ThatOneNode.RightChild = new Node1(ThatOneChar);
                return;
            }
            if (ThatOneChar < ThatOneNode.Value && ThatOneNode.LeftChild == null)
            {
                ThatOneNode.LeftChild = new Node1(ThatOneChar);
                return;
            }

            if (ThatOneChar >= ThatOneNode.Value)
            {
                Insert(ThatOneNode.RightChild, ThatOneChar);
            }
            else if (ThatOneChar < ThatOneNode.Value)
            {
                Insert(ThatOneNode.LeftChild, ThatOneChar);
            }
        }
        public bool Remove(char ThatOneChar)
        {
            throw new NotImplementedException();
        }
        private bool Remove(Node1 ThatOneNode, char ThatOneChar)
        {
            throw new NotImplementedException();
        }
        public bool Search(char ThatOneChar)
        {
            throw new NotImplementedException();
        }
        private bool Search(Node1 ThatOneNode, char ThatOneChar)
        {
            if (ThatOneChar > ThatOneNode.Value)
            {
                if (ThatOneNode.RightChild != null)
                {
                    Search(ThatOneNode.RightChild, ThatOneChar);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(ThatOneChar < ThatOneNode.Value)
            {
                if (ThatOneNode.LeftChild != null)
                {
                    Search(ThatOneNode.LeftChild, ThatOneChar);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (ThatOneChar == ThatOneNode.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PreOrderPrint()
        {
            throw new NotImplementedException();
        }
        private void PreOrderPrint(Node1 ThatOneNode)
        {
            throw new NotImplementedException();
        }
        public void InOrderPrint()
        {
            throw new NotImplementedException();
        }
        public void PostOrderPrint()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            BinaryTreePrinter.printNode(Root);
        }


    }
}
