##并行编程

* 数据并行

```csharp
	// Sequential version
	foreach (var item in sourceCollection)
	{
	    Process(item);
	}

	// Parallel equivalent
	Parallel.ForEach(sourceCollection, item => Process(item));
```



* 任务并行
 - Task
   - Start
   - ContinueWith
   - ContinueWhenAll/ContinueWhenAny
  
  
* PLINQ
 - .AsParallel()
 - .AsOrdered()
  
```csharp
	evenNums = from num in numbers.AsParallel().AsOrdered()
               where num % 2 == 0
               select num;
```