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
| SystemTextJson          | Seria(...)tives [29] | 966.41 ns | 60.219 ns | 3.301 ns | 963.19 ns | 969.79 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 897.79 ns | 24.045 ns | 1.318 ns | 896.46 ns | 899.10 ns | 0.0334 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  78.71 ns |  5.468 ns | 0.300 ns |  78.49 ns |  79.05 ns | 0.0072 |     120 B |
