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
| SystemTextJson          | Seria(...)tives [29] | 979.03 ns | 67.351 ns | 3.692 ns | 975.74 ns | 983.02 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 924.18 ns | 88.523 ns | 4.852 ns | 918.65 ns | 927.70 ns | 0.0334 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  76.69 ns |  7.231 ns | 0.396 ns |  76.31 ns |  77.10 ns | 0.0072 |     120 B |
