using AsyncBasics;

// Problem Statment 1
// You need to (asynchronously) wait for a period of time.
// This is a common scenario when unit testing or implementing retry delays.
// It also comes up when coding simple timeouts.

//DelayResultByAPeriodOfTime delayResultByAPeriodOfTime = new DelayResultByAPeriodOfTime(delayInSeconds: 5);
//int sum = await delayResultByAPeriodOfTime.AddTwoNumbersWithDelay(10, 20);
//Console.WriteLine(sum);

// Problem Statement 2
// You have some code that needs to stop running after a timeout.

//CancelAfterTimeout cancelAfterTimeout = new CancelAfterTimeout(cancelAfterSeconds: 5);
////await cancelAfterTimeout.IssueTimeoutAsync();
//string? concatenatedString = await cancelAfterTimeout.ConcatenateStringsWithTimeout(new string[] { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" });
//Console.WriteLine(concatenatedString);

// Problem Statement 3
// Awaiting for multiple async calls together and getting the results
//WaitingForMultipleTasks multipleTasks = new WaitingForMultipleTasks(delayInSeconds: 5);
//Task<int> addTask = multipleTasks.AddNumbersWithDelay(10, 20);
//Task<int> subtractTask = multipleTasks.SubtractNumbersWithDelay(25, 10);
//Task<int> multiplyTask = multipleTasks.MultiplyNumbersWithDelay(10, 20);

//await Task.WhenAll(addTask, subtractTask, multiplyTask);
//Console.WriteLine($"Add: {addTask.Result}, Subtract: {subtractTask.Result}, Multiply: {multiplyTask.Result}");
