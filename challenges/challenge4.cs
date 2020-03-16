using System;

namespace pae_csharpChallenges.challenges
{
    public class challenge4
    {
        /* 
            Challenge4: Binary Search Trees! Write a function that, efficiently with respect 
            to time used, checks if a given binary search tree contains a given value.

            Again this is a challenge from TestDome and can be found here:
            https://www.testdome.com/d/c-sharp-interview-questions/18
         */

        public class Node
        {
            public int Value { get; set; }

            public Node Left { get; set; }

            public Node Right { get; set; }

            public Node(int value, Node left, Node right)
            {
                Value = value;
                Left = left;
                Right = right;
            }
        }

        public static bool Contains(Node root, int value)
        {
            //throw new NotImplementedException("Waiting to be implemented.");
            
            // checks if the head node is null
            if (root == null)
            {
                // if it is return false
                return false;
            }
            // if the root valeu == value 
            else if (root.Value == value)
            {
                // return true as we've found the root
                return true;
            }
            // if the root value is less than value 
            else if (root.Value < value)
            {
                /* 
                    recursively call the method, this time going to the right
                    node as the root value is less than the given and the right
                    node contains the values that are greater than the head node
                 */
                return  Contains(root.Right, value);
            }
            // else it means that the root value is > value
            else
            {
                /* 
                    Therefor, recursively call the value going left of the BST because
                    the root value is greater than the value being searched for. Therefor
                    check the left hand side of tree.
                 */
                return Contains(root.Left, value);
            }
        }

        public static void challenge4Run()
        {
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            Console.WriteLine(Contains(n2, 3));
        }
        
    }
}