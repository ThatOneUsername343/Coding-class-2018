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

        private void Insert(Node1 ThatSecondNode, char ThatSecondChar)
        {
            if (ThatSecondChar >= ThatSecondNode.Value && ThatSecondNode.RightChild == null)
            {
                ThatSecondNode.RightChild = new Node1(ThatSecondChar);
                return;
            }
            if (ThatSecondChar < ThatSecondNode.Value && ThatSecondNode.LeftChild == null)
            {
                ThatSecondNode.LeftChild = new Node1(ThatSecondChar);
                return;
            }

            if (ThatSecondChar >= ThatSecondNode.Value)
            {
                Insert(ThatSecondNode.RightChild, ThatSecondChar);
            }
            else if (ThatSecondChar < ThatSecondNode.Value)
            {
                Insert(ThatSecondNode.LeftChild, ThatSecondChar);
            }
        }
        public bool Remove(char ThatThirdChar)
        {
            throw new NotImplementedException();
        }
        private bool Remove(Node1 ThatThirdNode, char ThatFourthChar)
        {
            throw new NotImplementedException();
        }
        public bool Search(char ThatFifthChar)
        {
            throw new NotImplementedException();
        }
        private bool Search(Node1 ThatFourthNode, char ThatSixthChar)
        {
            throw new NotImplementedException();
        }
        public void PreOrderPrint()
        {
            throw new NotImplementedException();
        }
        private void PreOrderPrint(Node1 ThatFifthNode)
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
