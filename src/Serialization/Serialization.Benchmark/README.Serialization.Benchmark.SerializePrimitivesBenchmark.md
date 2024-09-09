```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,007.50 ns |  9.638 ns | 0.528 ns | 1,006.97 ns | 1,008.02 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   921.69 ns | 14.314 ns | 0.785 ns |   921.20 ns |   922.59 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    95.07 ns |  4.356 ns | 0.239 ns |    94.85 ns |    95.32 ns | 0.0014 |     120 B |
