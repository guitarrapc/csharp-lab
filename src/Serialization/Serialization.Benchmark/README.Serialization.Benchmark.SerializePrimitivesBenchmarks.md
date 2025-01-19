```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error    | StdDev   | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|---------:|---------:|----------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 997.41 ns | 91.22 ns | 5.000 ns | 991.90 ns | 1,001.66 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 861.72 ns | 54.05 ns | 2.963 ns | 859.39 ns |   865.05 ns | 0.0334 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  77.51 ns | 26.38 ns | 1.446 ns |  76.52 ns |    79.17 ns | 0.0072 |     120 B |
