```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 648.94 ns | 15.053 ns | 0.825 ns | 648.17 ns | 649.81 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 691.04 ns | 52.925 ns | 2.901 ns | 689.32 ns | 694.39 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.35 ns |  6.010 ns | 0.329 ns |  57.98 ns |  58.62 ns | 0.0014 |     120 B |
