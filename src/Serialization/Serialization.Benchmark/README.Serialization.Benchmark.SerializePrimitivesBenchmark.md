```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,017.56 ns | 45.550 ns | 2.497 ns | 1,015.11 ns | 1,020.10 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   911.15 ns |  0.970 ns | 0.053 ns |   911.10 ns |   911.20 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    94.76 ns | 43.419 ns | 2.380 ns |    93.26 ns |    97.50 ns | 0.0014 |     120 B |
