using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeVerticalOrderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public IList<IList<int>> VerticalOrder(TreeNode root)
        {
            IList<IList<int>> res = new List<IList<int>>();
            if (root == null)
                return res;
            int min = 0;           //To track the left most span of the tree.
            int max = 0;          //To track the right most span of the tree.
            Dictionary<int, List<int>> verticalLevelNodes = new Dictionary<int, List<int>>();  //map vertical level -> nodes.
            Queue<int> leftToRightOrder = new Queue<int>();                     //For BFS to track vertical order (left to right)
            Queue<TreeNode> treeNodesQueue = new Queue<TreeNode>();      //For BFS to track tree nodes.
            treeNodesQueue.Enqueue(root);
            leftToRightOrder.Enqueue(0);
            while (treeNodesQueue.Count > 0)
            {
                int order = leftToRightOrder.Dequeue();
                TreeNode node = treeNodesQueue.Dequeue();
                List<int> currList;
                if (!verticalLevelNodes.TryGetValue(order, out currList))
                {    //Insert the curr node in the list
                    currList = new List<int>();
                    verticalLevelNodes[order] = currList;
                }
                currList.Add(node.val);
                if (node.left != null)
                {                    //Go to Left
                    treeNodesQueue.Enqueue(node.left);
                    leftToRightOrder.Enqueue(order - 1);
                    min = Math.Min(min, order - 1);
                }
                if (node.right != null)
                {                   //Go to Right
                    treeNodesQueue.Enqueue(node.right);
                    leftToRightOrder.Enqueue(order + 1);
                    max = Math.Max(max, order + 1);
                }
            }
            for (int i = min; i <= max; i++)    //Convert map to result
                res.Add(verticalLevelNodes[i]);
            return res;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
