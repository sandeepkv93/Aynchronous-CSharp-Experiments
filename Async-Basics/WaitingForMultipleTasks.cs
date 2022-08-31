using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncBasics
{
    public class WaitingForMultipleTasks
    {
        private readonly int delayInSeconds;

        public WaitingForMultipleTasks(int delayInSeconds)
        {
            this.delayInSeconds = delayInSeconds;
        }

        public async Task<int> AddNumbersWithDelay(int firstNumber, int secondNumber)
        {
            await Task.Delay(this.delayInSeconds * 1000);
            return firstNumber + secondNumber;
        }

        public async Task<int> SubtractNumbersWithDelay(int firstNumber, int secondNumber)
        {
            await Task.Delay(this.delayInSeconds * 1000);
            return firstNumber - secondNumber;
        }

        public async Task<int> MultiplyNumbersWithDelay(int firstNumber, int secondNumber)
        {
            await Task.Delay(this.delayInSeconds * 1000);
            return firstNumber * secondNumber;
        }
    }
}
