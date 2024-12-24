using System.Diagnostics;

namespace Task3
{
    internal class Program
    {
        public static int ConountOccurrence(int num)
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();
            int cnt = 0;

            for (int i = 0; i <= num; i++)
            {
                string temp = i.ToString();
                for (int k = 0; k < temp.Length; k++)
                {
                    if (temp[k] == '1')
                    {
                        cnt++;
                    }
                }
            }
            stw.Stop();

            Console.WriteLine($"With Time :{stw.ElapsedMilliseconds} ms ");

            return cnt;

        }
        public static long ConountOccurrenceV2(long n)
        {


            long count = 0;
            Stopwatch stw = new Stopwatch();
            stw.Start();

            for (long i = 0; i <= n; i++)
            {
                long num = i;


                while (num > 0)
                {
                    if (num % 10 == 1)
                    {
                        count++;
                    }
                    num /= 10;
                }
            }
            stw.Stop();

            Console.WriteLine($"With Time :{stw.ElapsedMilliseconds} ms ");
            return count;

        }

        public static long ConountOccurrenceV3(int num)
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();

            long count = 0;
            long d = num.ToString().Length;
            long pw = (long)Math.Pow(10, d - 1);
            count = d * pw;
            stw.Stop();

            Console.WriteLine($"With Time :{stw.ElapsedMilliseconds} ms ");

            return count;
        }

        static void Main(string[] args)
        {
            #region   count the occurrence of #

            #region    Convert Numbers to String v1
            //Console.WriteLine("Enter num: ");
            //int num = int.Parse(Console.ReadLine());
            //int ans = ConountOccurrence(num);
            //Console.WriteLine($"the Answer Is: {ans}");
            #endregion

            #region v2
            //Console.WriteLine("Enter num: ");
            //int num = int.Parse(Console.ReadLine());
            //long ans = ConountOccurrenceV2(num);
            //Console.WriteLine($"the Answer Is: {ans}");
            #endregion

            #region    Using  Mathematics v3
            //Console.WriteLine("Enter num: ");
            //int num = int.Parse(Console.ReadLine());
            //long ans = ConountOccurrenceV3(num);
            //Console.WriteLine($"the Answer Is: {ans}");
            #endregion

            #endregion
        }
    }
}
