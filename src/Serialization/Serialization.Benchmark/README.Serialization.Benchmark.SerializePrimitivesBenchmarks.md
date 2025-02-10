```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 987.14 ns | 137.44 ns | 7.534 ns | 982.66 ns | 995.84 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 883.87 ns |  20.07 ns | 1.100 ns | 882.75 ns | 884.94 ns | 0.0334 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  80.06 ns |  14.36 ns | 0.787 ns |  79.28 ns |  80.85 ns | 0.0072 |     120 B |
