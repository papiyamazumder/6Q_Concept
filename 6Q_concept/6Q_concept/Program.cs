using System.Diagnostics;
using System.Text;

namespace GaneshHandset
{
    internal class Program
    {
        // Q6)  Finding 2nd largest no in array using 1 loop only:- 

        #region Using foreach and taking user input in main function:
        //static void Main(string[] args)
        //{

        //    #region Taking user array input: 
        //    Console.Write("Enter the array size: ");
        //    int enter = Convert.ToInt32(Console.ReadLine());

        //    //int[] enterarr = {1,2,5,3,4,6};

        //    int[] enterarr = new int[50];
        //    Console.WriteLine("Enter the Array: ");
        //    for (int i = 0; i < enter; i++)                         // for loop bcs we want index and not the values
        //    {
        //        enterarr[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //    #endregion

        //    int output = SecMaxValue(enterarr);
        //    Console.Write("Second highest value in the Array is: " +  output);
        //}

        //static int SecMaxValue(int[] enterarr)
        //{
        //    int max = enterarr[0];
        //    int secmax = 0;         //int.MinValue;          

        //    foreach (int no in enterarr)                            // foreach bcs we want values not index 
        //    {
        //        if (no > max)
        //        {
        //            secmax = max;
        //            max = no;
        //            //secmax = max;
        //        }
        //        else if (no < max && no > secmax)
        //        {
        //            secmax = no;
        //        }
        //    }
        //    Console.Write("Highest Value in the Array: " + max + "\n");

        //    return secmax;
        //}

        #endregion

        #region Using for loop and user input in sub function

        //public static void Main(string[] args)
        //{
        //    //Program SecLargestdictObj = new Program();       // creating dictObj is optional
        //    //Program.SecLargest();

        //    //OR

        //    SecLargest();
        //}

        //public static int SecLargest()
        //{
        //    #region Input Array: 

        //    Console.Write("Enter Array Size: ");
        //    int a = int.Parse(Console.ReadLine());

        //    int[] arr = new int[50];
        //    Console.WriteLine("Enter Array Input: ");

        //    for (int i = 0; i < a; i++)
        //    {
        //        arr[i] = int.Parse(Console.ReadLine());
        //    }

        //    #endregion

        //    int max = arr[0];
        //    int secmax = 0;

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i]>max)
        //        {
        //            secmax = max;
        //            max = arr[i];
        //        }
        //        else if (arr[i]<max && arr[i]>=secmax)
        //        {
        //            secmax = arr[i];
        //        }
        //    }
        //    Console.Write("Highest Value in the Array: " + max);
        //    Console.WriteLine("\n");
        //    Console.Write("Second Highest Value in the Array: " + secmax);
        //    Console.WriteLine("");

        //    return SecLargest();
        //}

        #endregion


        // Q5)  Finding all possible substrings in a string:-   https://www.geeksforgeeks.org/program-print-substrings-given-string/

        #region Using 2 loops and substring method:
        //public static void Main(string[] args)
        //{
        //    Console.Write("Enter: ");
        //    string str = Console.ReadLine();

        //    Substring(str);
        //} 

        //public static void Substring(string str)        // pass no of parameter = return nof of parameter      
        //{ 
        //    int n = str.Length;

        //    for (int i = 0; i < n; i++)                 // i -> index
        //    {
        //        for (int j = 1; j <= n-i; j++)          // j -> length of str bcs substring function conatins index,length  -> i is index and j is length
        //        {
        //            Console.WriteLine(str.Substring(i,j));
        //        }
        //    }

        //}

        #endregion

        #region Using 3 loops and no substring function:

        //public static void Main(string[] args)
        //{
        //    Console.Write("Enter: ");
        //    string str = Console.ReadLine();

        //    Substring(str);
        //}

        //public static void Substring(string str)           
        //{
        //    int n = str.Length;

        //    for (int i = 0; i < n; i++)                 
        //    {
        //        for (int j = i; j < n; j++)          
        //        {
        //            for (int k = i; k <= j; k++)
        //            {
        //                Console.Write(str[k]);
        //            }

        //            Console.WriteLine();
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine();
        //}

        #endregion

        #region Using 2 loops & empty variable/stringbuilder and concatenation/append method:

        //public static void Main(string[] args)
        //{
        //    Console.Write("Enter: ");
        //    string str = Console.ReadLine();

        //    Substring(str);
        //}

        //public static void Substring(string str)
        //{
        //    int n = str.Length;

        //    for (int i = 0; i < n; i++)
        //    {
        //        string s = "";          // empty string assig to store values as we iterate

        //        //OR

        //        //StringBuilder s = new StringBuilder();        // create stringbuilder, to store new values and keep appending to it

        //        for (int j = i; j < n; j++)
        //        {
        //            s = s + str[j];

        //            //  OR

        //            //s.Append(str[j]);             // Append is must if we use string builder.  Cant use append w/o creating string builder

        //            Console.WriteLine(s);
        //        }
        //        Console.WriteLine();
        //    }
        //}

        #endregion


        // Q1) Occurance of each character in a string:- 

        #region W/O Dictionary, using comaparsion and increasing count

        //public static void Main(string[] args) 
        //{
        //    Console.Write("Enter string: ");
        //    string str = Console.ReadLine();

        //    RepeatedChar(str);
        //}

        //public static void RepeatedChar(string str) 
        //{
        //    string storechar = " ";

        //    for (int i = 0; i < str.Length; i++) 
        //    {
        //        int count = 0;

        //        for (int j = 0; j < str.Length; j++)
        //        {
        //            if (!storechar.Contains(str[j]))
        //            {
        //                if (str[i] == str[j])
        //                { 
        //                    count++;
        //                }
        //                else if (str.Contains(" "))
        //                {
        //                    continue;
        //                }
        //            }
        //        }
        //        storechar = storechar + str[i];
        //        if (count > 0)
        //        {
        //            Console.WriteLine(str[i] + ": " + count);
        //        }             
        //    }
        //}

        #endregion

        #region With Dictionary w/o return type

        //public static void Main(string[] args)
        //{
        //    Console.Write("Enter string: ");
        //    string str = Console.ReadLine();

        //    Dictionary<char, int> dictObj = new Dictionary<char, int>();     // Creating a dictionary with int keys and string values to store character counts
        //    CountCharacter(str, dictObj);        // Call the function to count each character
        //}

        //public static void CountCharacter(string str, Dictionary<char, int> dictObj)
        //{
        //    foreach (char character in str)
        //    {

        //        if (character == ' ')
        //        {
        //            continue;
        //        }
        //        else if (dictObj.ContainsKey(character))
        //        {
        //            dictObj[character]++;
        //        }
        //        else
        //        {
        //            dictObj[character] = 1;
        //        }
        //    }

        //    foreach (var c in dictObj)
        //    {
        //        Console.WriteLine("Character: " + c.Key + " & Value: " + c.Value);
        //        //OR
        //        Console.WriteLine(c.Key + " : " + c.Value);
        //    }
        //}

        #endregion

        #region With Dictionary and return Type

        //public static void Main(string[] args)
        //{
        //    Console.Write("Enter string: ");
        //    string str = Console.ReadLine();

        //    Dictionary<char, int> dictObj = new Dictionary<char, int>();
        //    dictObj = CountCharacter(str, dictObj);

        //    foreach (var c in dictObj)
        //    {
        //        // Console.WriteLine("Character: " + c.Key + " & Value: " + c.Value);
        //        // OR
        //        Console.WriteLine(c.Key + " : " + c.Value);
        //    }
        //}

        //public static Dictionary<char, int> CountCharacter(string str, Dictionary<char, int> dictObj)
        //{
        //    foreach (char character in str)
        //    {
        //        if (character == ' ')
        //        {
        //            continue;
        //        }
        //        else if (dictObj.ContainsKey(character))
        //        {
        //            dictObj[character]++;
        //        }
        //        else
        //        {
        //            dictObj[character] = 1;
        //        }
        //    }

        //    return dictObj;
        //}

        #endregion


        // Q2) Reverse a String:-

        #region Using Array>reverse() Fn:-
        //public static void Main(string[] args)
        //{
        //    Console.Write("Enter string: ");
        //    string str = Console.ReadLine();

        //    string RS = ReverseString(str);
        //    Console.WriteLine("Reversed String: " + RS);
        //}

        //public static string ReverseString(string str)
        //{
        //    char[] chararr = str.ToCharArray();     // chararr: It's an array of characters, obtained by calling ToCharArray() on a string. We are storing string values as char in an array.
        //    Array.Reverse(chararr);

        //    return new string(chararr);             // new string -> constructs a string from the characters in the array. Here, it converts the reversed character array back into a string.
        //}

        #endregion

        #region Using Pointer() Fn:
        //public static void Main(string[] args)
        //{
        //    Console.Write("Enter string: ");
        //    string str = Console.ReadLine();

        //    string RS = ReverseString(str);
        //    Console.WriteLine("Reversed String: " + RS);
        //}

        //public static string ReverseString(string str)
        //{
        //    char[] chararr = str.ToCharArray();     // chararr: It's an array of characters, obtained by calling ToCharArray() on a string. We are storing string values as char in an array.

        //    int start = 0;
        //    int end = str.Length-1;

        //    while (start < end)         // Using for loop: for (int start = 0, end = str.Length - 1; start < end; start++, end--)
        //    {
        //        // Swap characters at start and end positions
        //        char temp = chararr[start];
        //        chararr[start] = chararr[end];
        //        chararr[end] = temp;

        //        // Move towards the center
        //        start++;    
        //        end--;
        //    }
        //        return new string(chararr);             // new string -> constructs a string from the characters in the array. Here, it converts the reversed character array back into a string.
        //}

        #endregion


        // Q3) Reverse the order of words in a string:

        #region Using Array>reverse() Fn:-
        //public static void Main(string[] args)
        //{
        //    Console.Write("Enter strings: ");
        //    string strs = Console.ReadLine();

        //    string RWS = ReverseWordsString(strs);
        //    Console.WriteLine("Reversed String: " + RWS);
        //}

        //public static string ReverseWordsString(string strs)
        //{
        //   string[] words = strs.Split();
        //    Array.Reverse(words);
        //    string joinwords = string.Join(" ", words);

        //    return joinwords;             // new string -> constructs a string from the characters in the array. Here, it converts the reversed character array back into a string.
        //}

        #endregion

        #region Using for loop:-
        //public static void Main(string[] args)
        //{
        //    Console.Write("Enter strings: ");
        //    string strs = Console.ReadLine();

        //    string RWS = ReverseWordsString(strs);
        //    Console.WriteLine("Reversed String: " + RWS);
        //}

        //public static string ReverseWordsString(string strs)
        //{
        //    string[] words = strs.Split();
        //    string joinwords = " ";

        //    for (int i=words.Length-1; i>=0; i--)
        //    {
        //        joinwords = joinwords + words[i] + " ";
        //    }

        //    return joinwords.Trim();             // Remove the trailing space before returning as we are assigning empty var at first and then adding words to it. So there is a space at first
        //}

        #endregion


        // Q4) Reverse each word char in a string:-

        #region Using Split and 1 loop with Reverse function:

        //static void Main()
        //{
        //    Console.WriteLine("Enter a sentence:");
        //    string strs = Console.ReadLine();

        //    string RWS = ReverseWordsString(strs);
        //    Console.WriteLine("Reversed Words: " + RWS);
        //}

        //static string ReverseWordsString(string strs)
        //{
        //    string[] words = strs.Split(' '); // Split the sentence into an array of words
        //    string ReversedWords = " ";

        //    // Reverse each word individually using Array.Reverse
        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        char[] charArray = words[i].ToCharArray();
        //        Array.Reverse(charArray);
        //        words[i] = new string(charArray);     // Convert char array to string
        //    }
        //    ReversedWords = string.Join(" ", words);
        //    return ReversedWords;
        // OR
        //return string.Join(" ", words); // Join the reversed words back into a sentence
        //}

        // OR

        //static string ReverseWordsString(string strs)
        //{
        //    string[] words = strs.Split(' '); // Split the sentence into an array of words
        //    string reversedSentence = " ";

        //    // Reverse each word individually using Array.Reverse
        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        char[] charArray = words[i].ToCharArray();
        //        Array.Reverse(charArray); 

        //        string reverseWord = new string(charArray);     // Convert char array to string -> another way
        //        reversedSentence = reversedSentence + reverseWord + " "; // Concatenate reversed word with a space
        //    }
        //    return reversedSentence;
        //}

        #endregion

        #region Using Split and 2 loops:

        //public static void Main(string[] args)
        //{
        //    Console.Write("Enter strings: ");
        //    string strs = Console.ReadLine();

        //    string RWS = ReverseWordsString(strs);
        //    Console.WriteLine("Reversed String: " + RWS);
        //}

        //public static string ReverseWordsString(string strs)
        //{
        //    string[] words = strs.Split();
        //    string reversedString = "";

        //    for (int i = 0; i < words.Length; i++)      // starting from papiya mazumder, serially
        //        // OR
        //    //for (int i = words.Length - 1; i >= 0; i--)       // starting from mazumder papiya, reversing the string
        //    {
        //        char[] chars = words[i].ToCharArray();

        //        for (int j = chars.Length - 1; j >= 0; j--)
        //        {
        //            reversedString = reversedString + chars[j];         // Joining in an array                  
        //        }
        //        reversedString = reversedString + " "; // Add space between reversed words
        //    }
        //    return reversedString;
        //}

        #endregion


        // Q) Leetcode: nums and target, nums index = target, print index
        #region

        //public static void Main(string[] args)
        //{
        //    //int[] nums = { 2, 7, 11, 15 };
        //    int[] nums = { 3, 2, 4 };
        //    //int[] nums = {3,3};

        //    //int target = 9;
        //    int target = 6;
        //    //int target = 6;

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        for (int j = i + 1; j < nums.Length; j++)
        //        {
        //            int n = nums[i] + nums[j];
        //            if (n == target)
        //            {
        //                Console.WriteLine($" The index is: [ {i} , {j} ]");
        //            }
        //        }
        //    }
        //}

        #endregion

        // Q) Leetcode: Remove duplicated and return unique elements count and the sorted array:
        #region

        //public static void Main(string[] args)
        //{
        //    int[] nums = [1, 1, 2];     // user input
        //    int[] expectedNums = [];

        //    int k = removeDuplicates(nums);
        //}

        //public static int removeDuplicates(int[] nums)
        //{
        //    int k = 1;
        //    for (int i = 0; i < nums.Length - 1; i++)
        //    {
        //        if (nums[i] != nums[i + 1])
        //        {
        //            nums[k] = nums[i + 1];
        //            k++;
        //        }
        //    }
        //    Console.WriteLine($"Count is: {k}");

        //    // Print the unique array:
        //    //Console.Write("Array after removing duplicates: ");
        //    //for (int i = 0; i < k; i++)
        //    //{
        //    //    Console.Write(nums[i] + " , " );
        //    //}

        //    return k;
        //}

        #endregion

        //Q) Leetcode: Maximum profit/sum in an array (maths concept: if array is sorted, them largest-smalles no = difference between each no and its sum)
        #region
        public static void Main(string[] args)
        {
            //int[] prices = { 7, 1, 5, 3, 6, 4 };
            int[] prices = { 1, 2, 3, 4, 5 };
            //int[] prices = { 7, 6, 4, 3, 1 };

            int sum = 0;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < prices[i + 1])
                {
                    sum += (prices[i + 1] - prices[i]);
                }
            }
            Console.WriteLine(sum);
        }

        #endregion


        // 1) Remove all # to front and then print rest char/string

        #region using char #

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();

            string output = MoveHashToFront(input);
            Console.WriteLine("Output: " + output);
        }

        public static string MoveHashToFront(string input)
        {
            char hash = '#';
            int hashcount = 0;
            foreach (char c in input)
            {
                if (c == hash)
                    hashcount++;
            }

            //string storehash = new string(hash, hashcount);
            //string storechar = input.Replace(hash.ToString(), "");
            //string store = storehash + storechar;

            // OR
            string store = new string(hash, hashcount) + input.Replace(hash.ToString(), "");

            return store;
        }

        #endregion

        #region using string # : 3 ways

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();

            string output = MoveHashToFront(input);
            Console.WriteLine("Output: " + output);
        }

        public static string MoveHashToFront(string input)
        {
            string hash = "#";
            int hashcount = 0;
            foreach (var c in input)
            {
                if (c.ToString() == hash)
                    hashcount++;
            }

            //string storehash = new string(hash[0], hashcount);
            //string storechar = input.Replace(hash, "");
            //string store = storehash  + storechar;

            //OR
            string store = new string(hash[0], hashcount) + input.Replace(hash.ToString(), "");

            return store;
        }

        // OR

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();

            string output = MoveHashToFront(input);
            Console.WriteLine("Output: " + output);
        }
        public static string MoveHashToFront(string input)
        {
            string hash = "";
            foreach (var c in input)
            {
                if (c.ToString() == "#")
                    hash = hash + "#";
            }

            string storechar = input.Replace("#", "");
            string store = hash + storechar;

            return store;
        }

        // OR

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();

            string output = MoveHashToFront(input);
            Console.WriteLine("Output: " + output);
        }

        public static string MoveHashToFront(string input)
        {
            string hashPart = "";
            string nonHashPart = "";

            foreach (char c in input)
            {
                if (c == '#')
                {
                    hashPart += c;
                }
                else
                {
                    nonHashPart += c;
                }
            }
            return hashPart + nonHashPart;
        }

        #endregion

        #region using chararray[]

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();

            string output = MoveHashToFront(input);
            Console.WriteLine("Output: " + output);
        }

        public string MoveHashToFront(string input)
        {
            char[] chars = new char[input.Length];
            char[] chars1 = new char[input.Length];
            int j = 0, k = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '#')
                {
                    chars[j] = input[i];
                    j++;
                }
                else
                {
                    chars1[k] = input[i];
                    k++;
                }
            }
            string output = new string(chars);
            string output1 = new string(chars1);
            return output + output1;
        }

        #endregion

        #region using string builder

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();

            string output = MoveHashToFront(input);
            Console.WriteLine("Output: " + output);
        }

        static string MoveHashToFront(string input)
        {
            StringBuilder result = new StringBuilder();
            int hashCount = 0;

            foreach (char c in input)
            {
                if (c == '#')
                {
                    result.Insert(hashCount, c);
                    hashCount++;
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }

    // OR
    /
    static string MoveHashToFront(string input)
        {
            StringBuilder outputBuilder = new StringBuilder(input.Length);
            StringBuilder hashBuilder = new StringBuilder(input.Length);

            foreach (char c in input)
            {
                if (c == '#')
                {
                    hashBuilder.Append(c);
                }
                else
                {
                    outputBuilder.Append(c);
                }
            }
            return hashBuilder.ToString() + outputBuilder.ToString();
        }

        #endregion

        #region using Linq
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();

            string output = MoveHashToFront(input);
            Console.WriteLine("Output: " + output);
        }

        static string MoveHashToFront(string input)
        {
            int hashCount = 0;                // int hashCount = input.Count(c => c == '#');
            var result = new string(input.OrderBy(c => c == '#' ? hashCount++ : 1).ToArray());
            // OR
            var result1 = new string(input.Where(c => c == '#' ? hashCount++ < int.MaxValue : true).ToArray());

            return result;
        }
        #endregion

        #region using linq and string builder

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();

            string output = MoveHashToFront(input);
            Console.WriteLine("Output: " + output);
        }
        static string MoveHashToFront(string input)
        {
            int hashCount = input.Count(c => c == '#');
            StringBuilder result = new StringBuilder(input);

            for (int i = 0, count = 0; i < result.Length; i++)
            {
                if (result[i] == '#')
                {
                    result.Replace("#", "", i, 1); // Remove original '#' from its position
                    result.Insert(count, "#");
                    count++;
                }
            }
            return result.ToString();
        }
        #endregion


        // 2) Multiple occurances consecutively

        #region W/O dict and storing multiple time:

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();
            //string input = "aabbbbeeeeffgggh";

            string store = "";
            int count = 0;

            char pc = input[0];

            foreach (char cc in input)
            {
                if (cc == pc)
                {
                    count++;
                }
                else
                {
                    store = store + pc + count.ToString();
                    count = 1;
                }
                pc = cc;
            }
            string result = store + pc + count.ToString();
            Console.WriteLine(result);
        }
        #endregion

        #region W/O dict and using string builder:

        static void Main(string[] args)
        {
            Console.WriteLine("Enter input: ");
            //string input = Console.ReadLine();
            string input = "aabbbbeeeeffggg";

            StringBuilder store = new StringBuilder();
            int count = 0;

            char pc = input[0];

            foreach (char cc in input)
            {
                if (cc == pc)
                {
                    count++;
                }
                else
                {
                    store.Append(pc).Append(count);
                    count = 1;
                }
                pc = cc;
            }
            store.Append(pc).Append(count);

            Console.WriteLine(store.ToString());
        }

        #endregion

        #region With Dict and no stringbuilder:

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter input: ");
            string input = Console.ReadLine();
            //string input = "aabbbbeeeeffgggh";

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;      // dict[c]++; is an increment operation on the value associated with the key 'c'
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
            foreach (var item in dict)
            {
                Console.Write($"{item.Key}{item.Value}");
            }
        }

        #endregion

        #region With Dict and sb:

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter input: ");
            // string input = Console.ReadLine();
            string input = "aabbbbeeeeffgggh";

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            StringBuilder result = new StringBuilder();
            foreach (var item in dict)
            {
                result.Append($"{item.Key}{item.Value}");
                //OR
                result.Append(item.Key.ToString() + item.Value.ToString());    // + -> only if both are string format. Cant + character with integer.
            }

            Console.WriteLine(result.ToString());
        }

        #endregion


        // 3) Number of times each integer has occurred in the array

        #region using dict:
        private static void Main(string[] args)
        {
            // Taking input in an array and converting each elements to int:

            Console.Write("Enter the number of elements in the array: ");
            int no = int.Parse(Console.ReadLine());

            Console.Write("Enter the elements of the array separated by ,: ");
            int[] array = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);       // extract int from array, so convert each elements of array to int
                                                                                            // string[] stringArray = Console.ReadLine().Split(',');     // ***if it wud be string

            //// OR

            //Console.WriteLine("Enter the elements of the array separated by space:");
            //string[] inputArray = Console.ReadLine().Split(' ');
            //int[] arraystore = new int[inputArray.Length];          // creates a new integer array (arraystore) with the same length as the inputArray

            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    arraystore[i] = int.Parse(inputArray[i]);
            //}

            countoccurances(array);
        }

        public static void countoccurances(int[] array)
        {
            Dictionary<int, int> occurrences = new Dictionary<int, int>();

            foreach (int n in array)
            {
                if (occurrences.ContainsKey(n))
                {
                    occurrences[n]++;
                }
                else
                {
                    occurrences[n] = 1;
                }
            }
            foreach (var item in occurrences)
            {
                Console.WriteLine($"{item.Key} occurs {item.Value} times");
            }
        }

        #endregion

        #region w/o dict:
        static void Main()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter the elements of the array separated by ,: ");
            int[] array = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);

            int[] array = { 3, 3, 4, 1, 4, 5, 1, 0, 2 };

            PrintOccurrences(array);
        }

        static void PrintOccurrences(int[] array)
        {
            #region storing in string

            string storechar = " ";

            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                if (!storechar.Contains(array[i].ToString()))
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            count++;
                        }
                    }
                    if (count > 0)
                    {
                        Console.WriteLine($"{array[i]} occurs {count} times");  // printing 1 i loop after completion
                    }
                }
                storechar = storechar + array[i].ToString();        // store i after completing 1 i loop
            }

            #endregion

            #region storing in list

            List<int> listarray = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;

                if (!listarray.Contains(array[i]))
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{array[i]} occurs {count} times");      // after completing 1 loop of i, it prints output for tat character
                }
                listarray.Add(array[i]);        // it stores value after completing entire 1 i loop
            }

            #endregion
        }
        #endregion

    }
}


