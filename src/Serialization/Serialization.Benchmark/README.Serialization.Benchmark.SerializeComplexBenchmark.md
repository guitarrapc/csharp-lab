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
| SystemTextJson          | Seria(...)Class [29] | 637.03 ns |  4.587 ns | 0.251 ns | 636.76 ns | 637.26 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 721.30 ns | 25.728 ns | 1.410 ns | 719.67 ns | 722.18 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.99 ns |  6.214 ns | 0.341 ns |  58.67 ns |  59.35 ns | 0.0014 |     120 B |
