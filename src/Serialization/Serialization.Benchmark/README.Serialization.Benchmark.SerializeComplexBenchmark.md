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
| SystemTextJson          | Seria(...)Class [29] | 631.92 ns | 42.953 ns | 2.354 ns | 630.22 ns | 634.61 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 694.78 ns | 42.389 ns | 2.323 ns | 692.11 ns | 696.25 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.65 ns |  1.543 ns | 0.085 ns |  57.55 ns |  57.70 ns | 0.0014 |     120 B |
