```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 965.92 ns |  66.54 ns | 3.647 ns | 961.98 ns | 969.17 ns | 0.0048 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 871.82 ns | 121.71 ns | 6.671 ns | 866.81 ns | 879.40 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  89.24 ns |  14.61 ns | 0.801 ns |  88.74 ns |  90.16 ns | 0.0014 |     120 B |
