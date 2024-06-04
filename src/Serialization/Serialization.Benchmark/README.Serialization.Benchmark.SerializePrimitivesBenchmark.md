```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 992.21 ns | 20.815 ns | 1.141 ns | 990.96 ns | 993.19 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 920.32 ns | 67.696 ns | 3.711 ns | 917.22 ns | 924.43 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  95.90 ns |  3.956 ns | 0.217 ns |  95.76 ns |  96.15 ns | 0.0014 |     120 B |
