```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|----------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,003.55 ns | 71.423 ns | 3.915 ns | 999.09 ns | 1,006.42 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   919.36 ns | 37.233 ns | 2.041 ns | 917.01 ns |   920.76 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    97.21 ns |  4.509 ns | 0.247 ns |  97.07 ns |    97.50 ns | 0.0014 |     120 B |
