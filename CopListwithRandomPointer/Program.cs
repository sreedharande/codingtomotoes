using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopListwithRandomPointer
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public RandomListNode copyRandomList(RandomListNode head)
        {
            if (head == null) return null;

            Dictionary<RandomListNode, RandomListNode> randomDictionary = new Dictionary<RandomListNode, RandomListNode>();

            // loop 1. copy all the nodes
            RandomListNode node = head;
            while (node != null)
            {
                if (!randomDictionary.TryGetValue(node, out RandomListNode newNode))
                {
                    randomDictionary.Add(node, new RandomListNode(node.label));
                    node = node.next;                    
                }
            }

            // loop 2. assign next and random pointers
            node = head;
           
            while (node != null)
            {
                var newNode = randomDictionary[node];
                if (node.next != null)
                    newNode.next = randomDictionary[node.next];

                if (node.random != null)
                    newNode.random = randomDictionary[node.random];

                node = node.next;
            }

            return randomDictionary[head];
        }
    }

public class RandomListNode
{
    public int label;
    public RandomListNode next, random;
    public RandomListNode(int x) { this.label = x; }
};
}
