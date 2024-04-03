using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiboCsharp
{
    class Program
    {
        //declare a dictionary to hold the indices as the keys and the corresponding value as the the value
        //static IDictionary<int,int> fibs=new Dictionary<int,int>();

        static void Main(string[] args)
        {
            //int n = 6;
            //Console.WriteLine(Fibonacci(n));
            ////Console.WriteLine('b' - 'a');

            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //var len = arr.Length;
            //Console.WriteLine(len);
            //arr.ToList().ForEach(x => Console.Write(x));
            //Array.ForEach(arr, Console.WriteLine);
            //Console.WriteLine("[{0}]", string.Join(", ", arr));
            //var mid = (int)Math.Floor(len / 2d);
            //var left = arr.Take(mid);
            //var right = arr.Skip(mid);

            //Console.WriteLine("[{0}]", string.Join(", ", left));
            //Console.WriteLine("[{0}]", string.Join(", ", right));

            //string str = "apbe";
            ////var lst = new List<string>();
            ////lst.Max(c => c.Length);
            //var t = string.Concat(str.OrderBy(c => c));
            //Console.WriteLine(LengthOfLongestSubstring(" "));
            //str = "h g";
            //Console.WriteLine($"Reversed string({str}): {ReverseString(str)}");

            //Console.WriteLine(MoveWhitespaceToEnd(new char[] { 'c', 'v', ' ', 'c', 'v', 'b', 'c' }));
            //Console.WriteLine(MoveWhitespaceToEnd(new char[] { }));
            //Console.WriteLine(MoveWhitespaceToEnd(new char[] { ' ', ' ', 'c', 'a', 'v', ' ', 'k'}));

            //Console.WriteLine(CountConnectedComponentsDFSrecursion(new Dictionary<int, int[]> {
            //    { 0, new int[] { 8, 1, 5 } },
            //    { 1, new int[] { 0 } },
            //    { 5, new int[] { 0, 8 } },
            //    { 8, new int[] { 0, 5 } },
            //    { 2, new int[] { 3, 4 } },
            //    { 3, new int[] { 2, 4 } },
            //    { 4, new int[] { 3, 2 } }
            //}));

            //Console.WriteLine(CountConnectedComponentsDFS(new Dictionary<int, int[]> {
            //    { 0, new int[] {  1 } },
            //    { 1, new int[] { 0 } }
            //}));

            //Console.WriteLine(CountConnectedComponentsDFS(new Dictionary<int, int[]>
            //{
            //}));

            //Console.WriteLine(LargestConnectedComponentDFSrecursion(new Dictionary<int, int[]> {
            //    { 0, new int[] { 8, 1, 5 } },
            //    { 1, new int[] { 0 } },
            //    { 5, new int[] { 0, 8 } },
            //    { 8, new int[] { 0, 5 } },
            //    { 2, new int[] { 3, 4 } },
            //    { 3, new int[] { 2, 4 } },
            //    { 4, new int[] { 3, 2 } }
            //}));

            Console.WriteLine(MoveWhitespaceToEnd2(new char[] { ' ', ' ', 'c', 'a', 'v', ' ', 'k' }));
            Console.WriteLine(MoveWhitespaceToEnd2(new char[] { 'c', 'v', ' ', ' ',' ', 'v', 'b', 'c' }));
            Console.WriteLine(MoveWhitespaceToEnd2(new char[] { ' ', ' ',' ',' ',' ',' ', 'v', 'b', 'c' }));
            Console.WriteLine(MoveWhitespaceToEnd2(new char[] { ' ', 'v',' ',' ',' ',' ', 'v', 'b', 'c' }));
            Console.WriteLine(MoveWhitespaceToEnd2(new char[] { ' ', ' ',' ',' ',' ',' ' }));
            Console.WriteLine(Move5ToEnd2(new char[] { '5', '5', 'c', 'a', 'v', '5', 'k' }));

            //Console.WriteLine(Compress("ccaaatsss"));
            //Console.WriteLine(Compress(""));
            //Console.WriteLine(Compress("c"));
            //Console.WriteLine(Compress("yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy"));

            //Console.WriteLine(Anagrams("monkeyswrite", "newyorktimes"));
            //Console.WriteLine(Anagrams("taxi", "tax"));

            //Console.WriteLine(MostFrequentChar("mississippi"));

            //Console.WriteLine(PairSum(new int[] { 3, 2, 5, 4, 1 }, 8));
            //Console.WriteLine(PairSum(new int[] { 6, 4, 2, 8 }, 12));


            Console.WriteLine(PairProduct(new int[] { 3, 2, 5, 4, 1 }, 8));
            Console.WriteLine(PairProduct(new int[] { 4, 7, 9, 2, 5, 1 }, 5));

            Console.ReadKey();
        }

        static string PairProduct(int[] arr, int target)
        {
            //use the complement
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(target / arr[i]))
                {
                    return $" {dict[target / arr[i]]}, {i} ";
                }
                dict.Add(arr[i], i);
            }

            return null;
        }

        static string PairSum(int[] arr, int target)
        {
            //use the complement
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(target - arr[i]))
                {
                    return $" {dict[target - arr[i]]}, {i} ";
                }
                dict.Add(arr[i], i);
            }

            return null;
        }

        static char MostFrequentChar(string s)
        {
            var dict = new Dictionary<char, int>();
            foreach (var ch in s)
            {
                if (!dict.ContainsKey(ch))
                {
                    dict.Add(ch, 0);
                }

                dict[ch]++;
            }

            var max = 0;
            var chr = new KeyValuePair<char, int>();
            foreach (var item in dict)
            {
                if(item.Value > max)
                {
                    max = item.Value;
                    chr = item;
                }
            }
            return chr.Key;
        }
        static bool Anagrams(string s1, string s2)
        {
            //define a dictionary to hold count of each char in s1
            var dict = new Dictionary<char, int>();
            foreach (var ch in s1)
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch]++;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }

            //use s2 chars to decrement dict values
            foreach (var ch in s2)
            {
                if (!dict.ContainsKey(ch))
                {
                    return false;
                }
                dict[ch]--;
            }

            //finally check if all values of dict = zero. Otherwise return false
            foreach (var item in dict)
            {
                if (dict[item.Key] != 0)
                {
                    return false;
                }
            }
            return true;
        }
        static string Compress(string s)
        {
            //test case "ccaaatsss"
            var result = new StringBuilder();
            int j = 0;
            int k = 0;
            var charCnt = 0;
            while (k < s.Length)
            {
                //This is necessary to avoid referencing out of range index of the string, which will throw and exception.
                if(k == s.Length - 1)
                {
                    charCnt++;
                    result.Append(charCnt == 1 ? "" + s[j] : charCnt.ToString() + s[j]);

                }
                else if (s[j] == s[k]) {
                    charCnt++;
                }
                else
                {
                    result.Append(charCnt==1?"" + s[j] : charCnt.ToString() + s[j]);
                    j = k;
                    charCnt = 1;
                }
                k++;
            } 


            return result.ToString();
        }

        static char[] MoveWhitespaceToEnd2(char[] charArray)
        {
            if (charArray.Length <= 1)
            {
                return charArray;
            }

            int left = 0;
            for (int right = 0; right < charArray.Length; right++)
            {
                if (charArray[left] == ' ' && charArray[right] != ' ')
                {
                    charArray[left] = charArray[right];
                    charArray[right] = ' ';
                    left++;
                }
                else if (charArray[left] != ' ' && left < right)
                {
                    left++;
                }
            }
            return charArray;
        }

        static char[] MoveWhitespaceToEnd(char[] charArray)
        {
            if (charArray.Length <= 1)
            {
                return charArray;
            }

            int left = 0;
            for (int right = 0; right < charArray.Length; right++)
            {
                if (charArray[left] == ' ' && charArray[right] != ' ')
                {
                    charArray[left] = charArray[right];
                    charArray[right] = ' ';
                    left++;
                }
                else if (charArray[left] != ' ')
                {
                    left++;
                }
            }
            return charArray;
        }

        static char[] Move5ToEnd2(char[] charArray)
        {
            if (charArray.Length <= 1)
            {
                return charArray;
            }

            int left = 0;
            for (int right = 0; right < charArray.Length; right++)
            {
                if (charArray[left] == '5' && charArray[right] != '5')
                {
                    charArray[left] = charArray[right];
                    charArray[right] = '5';
                    left++;
                }
                while(charArray[left] != '5' && left < right)
                {
                    left++;
                }
            }
            return charArray;
        }

        static int CountConnectedComponentsDFS(Dictionary<int, int[]> graph)
        {
            int count = 0;
           
            Stack<int> stack = new Stack<int>();
            var visited = new HashSet<int>();

            foreach (var node in graph)
            {
                if (visited.Contains(node.Key))
                {
                    //This represents
                    continue;
                }
                else
                {
                    //This represents traversing a new component so increment count;
                    count++;
                }
                stack.Push(node.Key);
                while (stack.Count > 0)
                {
                    var current = stack.Pop();
                    if (visited.Contains(current))
                        continue;
                    visited.Add(current);
                    foreach (var item in graph[current])
                    {
                        stack.Push(item);
                    }
                    //stack.ToList().ForEach(c => Console.Write(c));
                }
                Console.WriteLine();
            }
            return count;
        }

        static int CountConnectedComponentsDFSrecursion(Dictionary<int, int[]> graph)
        {
            int count = 0;

            Stack<int> stack = new Stack<int>();
            var visited = new HashSet<int>();

            foreach (var node in graph)
            {

               if(TraverseNeighbors(graph, node.Key, visited) == true)
                {
                    count++;
                }
            }
                Console.WriteLine();
            return count;
        }

        private static bool TraverseNeighbors(Dictionary<int, int[]> graph, int node, HashSet<int> visited)
        {
            //if node is already visited, then it's already accounted for.
            if (visited.Contains(node))
            {
                return false;
            }

            //add node to visited
            visited.Add(node);

            //traverse neighbors of node
            foreach (var neighor in graph[node])
            {
                TraverseNeighbors(graph, neighor, visited);
            }

            //at this point we would have finished traversing all neighbors of node, which would then mean a connected component has been found
            return true;
        }
        
        static int LargestConnectedComponentDFSrecursion(Dictionary<int, int[]> graph)
        {
            int nodeCount = 0;
            int largest = int.MinValue;
            Stack<int> stack = new Stack<int>();
            var visited = new HashSet<int>();

            foreach (var node in graph)
            {

                nodeCount = LargestTraverseNeighbors(graph, node.Key, visited);
                largest = Math.Max(nodeCount, largest);
            }
                Console.WriteLine();
            return largest;
        }

        private static int LargestTraverseNeighbors(Dictionary<int, int[]> graph, int node, HashSet<int> visited)
        {
            int nodeCount = 0;
            //if node is already visited, then it's already accounted for.
            if (visited.Contains(node))
            {
                return 0;
            }

            //add node to visited
            visited.Add(node);
            nodeCount++;
            //traverse neighbors of node
            foreach (var neighor in graph[node])
            {
                nodeCount += LargestTraverseNeighbors(graph, neighor, visited);
            }

            //at this point we would have finished traversing all neighbors of node, which would then mean a connected component has been found
            return nodeCount;
        }

        //static char[] MoveWhitespaceToEnd(char[] charArray)
        //{
        //    if (charArray.Length <= 1)
        //    {
        //        return charArray;
        //    }

        //    int left = 0, right = 1;
        //    while(right < charArray.Length || left<right)
        //    {

        //        if (charArray[left] == ' ' && charArray[right >= charArray.Length ? charArray.Length - 1 : right] != ' ')
        //        {
        //            charArray[left] = charArray[right == charArray.Length ? charArray.Length - 1 : right];
        //            charArray[right == charArray.Length ? charArray.Length - 1 : right] = ' ';
        //            left++;
        //        }
        //        if (right < charArray.Length)
        //        {
        //            right++;
        //        }
        //        else
        //        {
        //            if (left < right)
        //            {
        //                left++;
        //            }
        //        }

        //    }
        //    return charArray;
        //}

        static int Fibonacci(int i, Dictionary<int, int> fibs=null)
        {
            if(fibs is null)
            {
                fibs = new Dictionary<int, int>();
            }

            if (fibs.Keys.Contains(i))
            {
                return fibs[i];
            }

            if (i < 2)
                return i;

            fibs[i] = Fibonacci(i - 2, fibs) + Fibonacci(i - 1, fibs);
            return fibs[i];
        }

        static string ReverseString(string str)
        {
            if(str.Length <= 1)
            {
                return str;
            }
            return  ReverseString(str.Substring(1))+ str.First();
        }

        static int LengthOfLongestSubstring(string s)
        {
            int maxLen = 0;
            List<char> currentSubArr = new List<char>();

            if (s.Length <= 1)
            {
                return s.Length;
            }
            var charPos = 0;
            while (charPos < s.Length)
            {
                var cha = s[charPos];
                if (currentSubArr.Contains(cha))
                {
                    //Add currentSub to substring list
                    maxLen = currentSubArr.Count > maxLen ? currentSubArr.Count : maxLen;
                    //char repeated. 
                    //set charPos to one location after previous location of repeated char
                    charPos = s.Substring(0, charPos).LastIndexOf(cha) + 1;
                    //reset currentSub;
                    //currentSub = new StringBuilder();
                    //currentSub.Append(s[charPos]);
                    currentSubArr = new List<char>
                    {
                        s[charPos]
                    };
                    charPos++;
                }
                else
                {
                    currentSubArr.Add(s[charPos]);
                    charPos++;
                }

                //break if end of string else continue
                if (charPos == s.Length)
                {
                    //Add currentSub to substring list
                    maxLen = currentSubArr.Count > maxLen ? currentSubArr.Count : maxLen;
                    break;
                }
            }
            return maxLen;
        }
//                    for (var i = 0; i<s.Length; i++)
//            {
//                if (currentSub.ToString().Contains(s[charPos]) || i == s.Length - 1)
//                {

//                    //break if end of string else continue
//                    if (i == s.Length - 1)
//                    {
//                        currentSub.Append(s[charPos]);
//                        //Add currentSub to substring list
//                        substrings.Add(currentSub.ToString());
//                        break;
//                    }
//                    else
//                    {
//                        //Add currentSub to substring list
//                        substrings.Add(currentSub.ToString());
//                        //char repeated. 
//                        //set charPos to one location after previous location of repeated char
//                        charPos = s.IndexOf(s[charPos]) + 1;
//                        //reset currentSub;
//                        currentSub = new StringBuilder();
//    //currentSub.Append(s[charPos]);
//}
//                }
//                else
//                {
//                    currentSub.Append(s[charPos]);
//                    charPos++;
//                }
//            }

        //static int LengthOfLongestSubstring(string s)
        //{
        //    IList<string> substrings = new List<string>();
        //    StringBuilder tempsubstring = new StringBuilder();

        //    if (s.Length == 1)
        //    {
        //        return 1;
        //    }

        //    int i = 0;
        //    int j = 0;
        //    var tempStr = s;
            
        //    while (j < s.Length)
        //    {
        //        var cha = tempStr[i];
        //        if (!tempsubstring.ToString().Contains(cha))
        //        {
        //            tempsubstring.Append(cha);
        //            i++;
        //            if (i >= tempStr.Length)
        //            {
        //                substrings.Add(tempsubstring.ToString());
        //                break;
        //            }
        //        }
        //        else
        //        {
        //            substrings.Add(tempsubstring.ToString());
        //            tempsubstring = new StringBuilder();
        //            tempsubstring.Append(cha);
        //            //shift i to first occurence of the repeated tempStr[i] in the current s
        //            i = tempStr.IndexOf(cha);
        //            //
        //            tempStr = tempStr.Substring(i + 1);
        //        }
        //        j++;
        //    }
        //    return substrings.Count == 0?0: substrings.Max(c => c.Length);
        //}
    }

    class Graph
    {
        static void AddEdge(LinkedList<int>[] adj, int i, int j)
        {
            adj[i].AddLast(j);
            adj[j].AddLast(i);
        }
    }
}
