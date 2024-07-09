```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 632.25 ns |  6.868 ns | 0.376 ns | 631.87 ns | 632.62 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 686.45 ns | 12.494 ns | 0.685 ns | 685.93 ns | 687.23 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  59.21 ns |  1.119 ns | 0.061 ns |  59.14 ns |  59.26 ns | 0.0014 |     120 B |
