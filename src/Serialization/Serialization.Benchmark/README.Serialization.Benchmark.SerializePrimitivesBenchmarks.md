```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|----------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,000.06 ns |  4.793 ns | 0.263 ns | 999.78 ns | 1,000.30 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   902.48 ns | 11.377 ns | 0.624 ns | 902.03 ns |   903.19 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    94.51 ns | 27.127 ns | 1.487 ns |  93.55 ns |    96.23 ns | 0.0014 |     120 B |
