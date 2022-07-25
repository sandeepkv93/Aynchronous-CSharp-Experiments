﻿using AsyncBasics;

// Problem Statment 1
// You need to (asynchronously) wait for a period of time.
// This is a common scenario when unit testing or implementing retry delays.
// It also comes up when coding simple timeouts.

DelayResultByAPeriodOfTime delayResultByAPeriodOfTime = new DelayResultByAPeriodOfTime(delayInSeconds: 5);
int sum = await delayResultByAPeriodOfTime.AddTwoNumbersWithDelay(10, 20);
Console.WriteLine(sum);