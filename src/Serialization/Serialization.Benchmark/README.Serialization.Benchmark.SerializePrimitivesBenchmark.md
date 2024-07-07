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
| SystemTextJson          | Seria(...)tives [29] | 1,024.18 ns | 19.984 ns | 1.095 ns | 1,022.99 ns | 1,025.14 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   925.94 ns |  5.790 ns | 0.317 ns |   925.62 ns |   926.26 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    92.70 ns |  7.255 ns | 0.398 ns |    92.26 ns |    93.02 ns | 0.0014 |     120 B |
