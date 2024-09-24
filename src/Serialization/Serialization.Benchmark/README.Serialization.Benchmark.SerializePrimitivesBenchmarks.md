```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev    | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|----------:|----------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,002.08 ns |  89.27 ns |  4.893 ns | 998.53 ns | 1,007.66 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   919.71 ns | 223.27 ns | 12.238 ns | 905.89 ns |   929.17 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    91.56 ns |  27.42 ns |  1.503 ns |  89.83 ns |    92.57 ns | 0.0014 |     120 B |
