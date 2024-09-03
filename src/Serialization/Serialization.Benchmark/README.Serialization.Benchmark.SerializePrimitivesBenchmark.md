```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|----------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,070.42 ns | 212.46 ns | 11.645 ns | 1,057.41 ns | 1,079.85 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   950.75 ns | 161.77 ns |  8.867 ns |   941.65 ns |   959.37 ns | 0.0057 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    99.28 ns |  11.29 ns |  0.619 ns |    98.60 ns |    99.80 ns | 0.0014 |     120 B |
