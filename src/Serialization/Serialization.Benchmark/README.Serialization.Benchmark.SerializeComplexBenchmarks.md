```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 636.16 ns | 29.301 ns | 1.606 ns | 634.80 ns | 637.93 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 691.99 ns | 36.599 ns | 2.006 ns | 690.48 ns | 694.26 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.50 ns |  6.989 ns | 0.383 ns |  58.16 ns |  58.92 ns | 0.0014 |     120 B |
