```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,007.82 ns | 13.509 ns | 0.740 ns | 1,007.34 ns | 1,008.67 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   910.19 ns |  1.862 ns | 0.102 ns |   910.09 ns |   910.29 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    94.88 ns |  4.792 ns | 0.263 ns |    94.66 ns |    95.17 ns | 0.0014 |     120 B |
