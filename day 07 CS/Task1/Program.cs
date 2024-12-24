namespace Task1
{
    internal class Program
    {
        public static int FindLongestDistacne(int[] arr)
        {
            var dic = new Dictionary<int, int>();

            int maxDis = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                {
                    int temp = (i - dic[arr[i]]) - 1;
                    maxDis = Math.Max(maxDis, temp);
                }
                else
                {
                    dic[arr[i]] = i;
                }
            }
            return maxDis;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size  arr:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter elements of arr:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int res = FindLongestDistacne(arr);
            Console.WriteLine($"The Longest Distance is: {res}");

        }
    }
}
