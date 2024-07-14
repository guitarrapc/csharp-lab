```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|----------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 678.48 ns | 612.16 ns | 33.555 ns | 657.60 ns | 717.18 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 682.27 ns |  77.85 ns |  4.267 ns | 679.72 ns | 687.20 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.42 ns |  10.33 ns |  0.566 ns |  56.76 ns |  57.77 ns | 0.0014 |     120 B |
