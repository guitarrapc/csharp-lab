```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,026.03 ns |  31.205 ns | 1.710 ns | 1,024.38 ns | 1,027.79 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   950.25 ns | 133.751 ns | 7.331 ns |   945.92 ns |   958.72 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    94.24 ns |   1.089 ns | 0.060 ns |    94.17 ns |    94.28 ns | 0.0014 |     120 B |
