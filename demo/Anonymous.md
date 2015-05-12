##匿名(Anonymous)

* 匿名类

``` csharp
	var anonymous = new { Id = 1, Name = "Kitty" };
	Console.WriteLine(anonymous.Name);
```



* 匿名方法

```csharp
	Predicate<int> pred = new Predicate<int>(delegate(int d) { return d > 0; }); 
```
