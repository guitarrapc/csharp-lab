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
| SystemTextJson          | Seria(...)tives [29] | 988.30 ns | 79.713 ns | 4.369 ns | 985.69 ns | 993.34 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 875.23 ns | 37.732 ns | 2.068 ns | 873.74 ns | 877.59 ns | 0.0334 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  80.18 ns |  3.335 ns | 0.183 ns |  80.02 ns |  80.38 ns | 0.0072 |     120 B |
