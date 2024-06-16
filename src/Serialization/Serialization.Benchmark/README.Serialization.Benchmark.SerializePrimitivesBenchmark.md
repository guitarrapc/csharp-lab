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
| SystemTextJson          | Seria(...)tives [29] | 1,004.90 ns |  4.761 ns | 0.261 ns | 1,004.62 ns | 1,005.13 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   940.12 ns | 28.295 ns | 1.551 ns |   939.11 ns |   941.91 ns | 0.0057 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    93.28 ns |  2.348 ns | 0.129 ns |    93.16 ns |    93.42 ns | 0.0014 |     120 B |
