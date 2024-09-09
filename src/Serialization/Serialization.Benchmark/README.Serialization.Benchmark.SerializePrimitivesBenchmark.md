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
| SystemTextJson          | Seria(...)tives [29] | 1,029.33 ns | 118.118 ns | 6.474 ns | 1,023.96 ns | 1,036.52 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   926.87 ns |  47.476 ns | 2.602 ns |   925.32 ns |   929.88 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    94.92 ns |   8.015 ns | 0.439 ns |    94.48 ns |    95.36 ns | 0.0014 |     120 B |
