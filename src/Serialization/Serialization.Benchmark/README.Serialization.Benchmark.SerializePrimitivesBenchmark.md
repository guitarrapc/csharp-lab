```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,010.98 ns | 23.012 ns | 1.261 ns | 1,009.76 ns | 1,012.28 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   907.66 ns | 36.121 ns | 1.980 ns |   905.46 ns |   909.29 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    91.91 ns |  4.225 ns | 0.232 ns |    91.64 ns |    92.06 ns | 0.0014 |     120 B |
