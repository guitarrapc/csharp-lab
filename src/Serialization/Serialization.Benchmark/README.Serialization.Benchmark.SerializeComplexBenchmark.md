```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 648.63 ns | 29.055 ns | 1.593 ns | 646.80 ns | 649.71 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 702.19 ns | 53.911 ns | 2.955 ns | 700.15 ns | 705.58 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  63.57 ns |  4.765 ns | 0.261 ns |  63.33 ns |  63.85 ns | 0.0014 |     120 B |
