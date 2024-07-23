```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 659.70 ns | 13.940 ns | 0.764 ns | 658.84 ns | 660.30 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 694.18 ns | 51.437 ns | 2.819 ns | 691.24 ns | 696.86 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  61.04 ns |  7.405 ns | 0.406 ns |  60.57 ns |  61.30 ns | 0.0014 |     120 B |
