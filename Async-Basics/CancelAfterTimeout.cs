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
    }
}
