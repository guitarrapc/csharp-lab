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
| SystemTextJson          | Seria(...)Class [29] | 633.53 ns | 24.656 ns | 1.351 ns | 632.26 ns | 634.95 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 704.67 ns | 38.744 ns | 2.124 ns | 702.84 ns | 707.00 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  59.17 ns |  1.391 ns | 0.076 ns |  59.12 ns |  59.26 ns | 0.0014 |     120 B |
