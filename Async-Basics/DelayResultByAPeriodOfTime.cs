using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncBasics
{
    public class DelayResultByAPeriodOfTime
    {
        private int DelayInSeconds { get; set; }

        public DelayResultByAPeriodOfTime(int delayInSeconds)
        {
            this.DelayInSeconds = delayInSeconds;
        }

        static async Task<T> DelayResult<T>(T result, TimeSpan delay)
        {
            await Task.Delay(delay);
            return result;
        }

        internal async Task<int> AddTwoNumbersWithDelay(int a, int b)
        {
            int sum = a + b;
            return await DelayResult(sum, TimeSpan.FromSeconds(this.DelayInSeconds));
        }
    }
}
