namespace AsyncBasics
{
    public class CancelAfterTimeout
    {
        private int CancelAfterSeconds { get; set; }

        public CancelAfterTimeout(int cancelAfterSeconds)
        {
            this.CancelAfterSeconds = cancelAfterSeconds;
        }

        public async Task IssueTimeoutAsync()
        {
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(CancelAfterSeconds));
            CancellationToken token = cts.Token;
            await Task.Delay(TimeSpan.FromSeconds(10), token);
        }

        public async Task<string?> ConcatenateStringsWithTimeout(string[] stringArray)
        {
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(CancelAfterSeconds));
            Task<string> concatenateTask = ConcatenateStrings(stringArray);
            Task timeoutTask = Task.Delay(Timeout.InfiniteTimeSpan, cts.Token);

            Task completedTask = await Task.WhenAny(concatenateTask, timeoutTask);
            if (completedTask == timeoutTask)
            {
                return null;
            }
                
            return await concatenateTask;
        }

        async Task<string> ConcatenateStrings(string[] stringArray)
        {
            await Task.Delay(TimeSpan.FromSeconds(6));
            return string.Concat(stringArray);
        }
    }
}
