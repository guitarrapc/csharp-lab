```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|----------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,000.99 ns | 134.50 ns | 7.372 ns | 992.86 ns | 1,007.23 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   960.35 ns |  27.91 ns | 1.530 ns | 959.40 ns |   962.12 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    97.47 ns |  11.42 ns | 0.626 ns |  96.99 ns |    98.18 ns | 0.0014 |     120 B |
