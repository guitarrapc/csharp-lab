```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error    | StdDev   | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|---------:|---------:|----------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,000.16 ns | 27.20 ns | 1.491 ns | 998.55 ns | 1,001.49 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   902.75 ns | 43.84 ns | 2.403 ns | 900.02 ns |   904.56 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    94.43 ns | 19.05 ns | 1.044 ns |  93.71 ns |    95.63 ns | 0.0014 |     120 B |
