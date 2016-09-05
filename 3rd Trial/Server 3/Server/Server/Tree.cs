using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Tree
    {
        Node top;

        public Tree()
        {
            top = null;
        }

        public Tree(int initial)
        {
            top = new Node(initial);
        }

        public void Add(int value)
        {
            //non-recurse add
            if (top == null) // = the tree is empty
            {
                //Add item as the base node
                Node NewNode = new Node(value);
                top = NewNode;
                return;
            }
            Node currentNode = top;
            bool added = false;
            do
            {
                // traverse tree 
                if (value < currentNode.value)
                {
                    // go left
                    if (currentNode.left == null)
                    {
                        //add the item
                        Node NewNode = new Node(value);
                        currentNode.left = NewNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }
                if (value >= currentNode.value)
                {
                    if (currentNode.right == null)
                    {
                        Node NewNode = new Node(value);
                        currentNode.right = NewNode;
                        added = true;
                    }
                    else
                    {
                        //go right
                        currentNode = currentNode.right;
                    }
                }
            }

            while (!added);
        }

        public void AddRc(int value)
        {
            //recurse add
            AddR(ref top, value);
        }

        private void AddR(ref Node N, int value)
        {
            //private recursive search for where to add node
            if (N == null)
            {
                //Node doesn't exist add it here
                Node NewNode = new Node(value);
                N = NewNode; //Set the old Node reference to the newly created node, attaching it to the tree
                return; //end the function call and fall back
            }
            else if (value < N.value)
            {
                AddR(ref N.left, value);
                return;
            }
            else if (value >= N.value)
            {
                AddR(ref N.right, value);
                return;
            }
        }

        public void Print(Node N, ref string s)
        {
            //write out the tree in sorted order to the string newstring
            //implement using recursion
            if (N == null)
            {
                N = top;
            }
            else if (N.left != null)
            {
                Print(N.left, ref s);
                s = s + N.value.ToString().PadLeft(3);
            }
            else
            {
                s = s + N.value.ToString().PadLeft(3);
            }
            if (N.right != null)
            {
                Print(N.right, ref s);
            }
        }


    }
}
