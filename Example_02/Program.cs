using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Example_02
{
    class Program
    {
        private static int count = 0;
        private static object obj = new object();

        static void Main(string[] args)
        {
            int start = 100_000_000;
            int len = 100_000_000;
            int mid = len / 2;

            //IEnumerable<int> nums = Enumerable.Range(1_000_000_000, 1_000_000_000).ToList();
            List<int> nums1 = Enumerable.Range(start, mid).ToList();
            List<int> nums2 = Enumerable.Range(mid, len - mid).ToList();

            Stopwatch stopwatch = new Stopwatch();
            count = 0;
            stopwatch.Start();

            //StartAsync(nums);
            Task t = Task.Factory.StartNew(() =>
            {
                Task t1 = Task.Factory.StartNew(() =>
                {
                    foreach (var i in nums1)
                    {
                        IsSumOfDigitsIsMultipleOfNumber(i);
                    }
                });
                Task t2 = Task.Factory.StartNew(() =>
                {
                    foreach (var i in nums2)
                    {
                        IsSumOfDigitsIsMultipleOfNumber(i);
                    }
                });

                t1.Wait();
                t2.Wait();
            });
            t.Wait();
            stopwatch.Stop();

            Console.WriteLine($"Время потраченное с многозадачностью: {stopwatch.ElapsedMilliseconds}");

            Console.WriteLine("Количество чисел, сумма цифр которых кратно последней цифре " +
                              $"от {start} до {start + len} равняется - {count}.");

            Console.WriteLine("Теперь проход в одном потоке:");

            count = 0;
            stopwatch.Reset();
            stopwatch.Start();

            foreach (var i in nums1)
            {
                IsSumOfDigitsIsMultipleOfNumber(i);
            }
            foreach (var i in nums2)
            {
                IsSumOfDigitsIsMultipleOfNumber(i);
            }

            stopwatch.Stop();

            Console.WriteLine($"Время потраченное на решение в одном потоке: {stopwatch.ElapsedMilliseconds}");
            Console.WriteLine("Количество чисел, сумма цифр которых кратно последней цифре " +
                              $"от {start} до {start + len} равняется - {count}.");
        }

        /// <summary>
        /// Кратна ли сумма цифр числа последней цифре.
        /// </summary>
        /// <param name="num">Число.</param>
        /// <returns>Кратно?</returns>
        static void IsSumOfDigitsIsMultipleOfNumber(int num)
        {
            var x = num;
            var lastDigit = num % 10;

            if (lastDigit == 0)
                return;

            var sum = 0;

            while (x > 0)
            {
                sum += x % 10;
                x /= 10;
            }


            lock (obj)
            {
                count = sum % lastDigit == 0 ? count + 1 : count;
            }
        }

        //static void IsSumOfDigitsIsMultipleOfNumber(int num)
        //{
        //    var x = num.ToString();
        //    var lastDigit = num % 10;

        //    if (lastDigit == 0)
        //        return;

        //    var sum = 0;

        //    for (int i = 0; i < x.Length; i++)
        //    {
        //        sum += Convert.ToInt32(char.ToString(x[i]));
        //    }


        //    lock (obj)
        //    {
        //        count = sum % lastDigit == 0 ? count + 1 : count;
        //    }

        //}
    }
}
