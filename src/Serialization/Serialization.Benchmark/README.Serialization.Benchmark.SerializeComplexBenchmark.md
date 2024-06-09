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
| SystemTextJson          | Seria(...)Class [29] | 635.43 ns |  7.428 ns | 0.407 ns | 635.15 ns | 635.90 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 686.51 ns | 16.853 ns | 0.924 ns | 685.92 ns | 687.57 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  62.76 ns |  7.884 ns | 0.432 ns |  62.48 ns |  63.26 ns | 0.0014 |     120 B |
