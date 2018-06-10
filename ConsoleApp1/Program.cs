using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }

    public class TreeNode
    {
        int data;
        private TreeNode left;
        private TreeNode right;
        public TreeNode(int data)
        {
            this.data = data;
        }

        public List<int> PostorderTraversal(TreeNode root)
        {
            List<int> results = new List<int>();
            Stack<TreeNode> s1 = new Stack<TreeNode>();
            Stack<TreeNode> s2 = new Stack<TreeNode>();

            TreeNode current = root;
            s1.Push(current);

            while(s1.Count != 0)
            {
                current = s1.Pop();
                s2.Push(current);

                if (current.left != null)
                    s1.Push(current.left);
                if (current.right != null)
                    s1.Push(current.right);
            }

            while(s2.Count !=0)
            {
                results.Add(s2.Pop().data);
            }
           
            return results;
        }
    }
}
