using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveInvalidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> results = removeInvalidParentheses("()())()");
            bool s = isValid("()()");
        }

        /// <summary>
        /// its essential advantage is at process redundant ")" from left to right, 
        /// process redundant "(" from right to left, I think everyone understand this. 
        /// Then let's focus on 2 contiguous recursions. Let's take '())())' as an example:
        /// first recursion, last_ j = 1, the string is ())()), after deleting it the string is () ()). 
        /// I once thought that since s[0] and s[1] is valid now like()()), we don't need to change s[0]+s[1] in later steps. 
        /// But in fact it is not true, s[1] is still possible to be deleted in later steps, and the right logic should be: once a ")" is deleted, 
        /// we should restart from i=0, j=0 to look for the invalid ")" and do the recursion, and check those duplicates, 
        /// this is the right way to find all possible answers, 
        /// just like in the above example, in the second recursion in principle we should start looking for redundant ")" 
        /// from i=0, j=0, and take care there will be duplicates { which means that working on ()()) 
        /// and find i=4, j=1, string is like ()()), and then delete this s[j] }. 
        /// If we start from i=2, j=2, some answers will be missed. 
        /// Fortunately, we don't need to restart from i = 0, j = 0 for each recursion, 
        /// since all possible transformation before last_ j has been covered in previous recursions, 
        /// { but all possible transformations in range[last_ j, last_i] are not, 
        /// take another example, () () r)), first recursion can cover()() r)), ()() r)), but won't cover ()()r)) } , 
        /// we just need to restart from j = last_ j. That's why last_ j is necessary.On the other hand, value i can restart from last_i, too.
        /// I kind of like thinking of that the reason of choosing i and j are independent to each....
        /// next recursion starts from i, not i+1 as mentioned by somebody before, since 1 char is deleted, index i is automatically advanced one position
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static List<String> removeInvalidParentheses(String s)
        {
            List<String> res = new List<string>();

            // sanity check
            if (s == null) return res;

            List<String> visited = new List<String>();
            List<String> queue = new List<String>();

            // initialize
            queue.Add(s);
            visited.Add(s);

            bool found = false;

            while (queue.Count != 0)
            {
                s = queue.FirstOrDefault();

                if (isValid(s))
                {
                    // found an answer, add to the result
                    res.Add(s);
                    found = true;
                }
                else
                {
                    queue.Remove(s);
                }
               

                if (found) continue;

                // generate all possible states
                for (int i = 0; i < s.Length; i++)
                {
                    // we only try to remove left or right paren
                    if (s[i] != '(' && s[i] != ')') continue;

                    String t = s.Substring(0, i) + s.Substring(i + 1);

                    if (!visited.Contains(t))
                    {
                        // for each state, if it's not visited, add it to the queue
                        queue.Add(t);
                        visited.Add(t);
                    }
                }
            }

            return res;
        }

        // helper function checks if string s contains valid parantheses
        public static bool isValid(String s)
        {
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '(') count++;
                if (c == ')' && count-- == 0) return false;
            }

            return count == 0;
        }
    }
}
