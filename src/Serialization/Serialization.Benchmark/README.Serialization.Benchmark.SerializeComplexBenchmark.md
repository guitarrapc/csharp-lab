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
| SystemTextJson          | Seria(...)Class [29] | 648.55 ns | 30.588 ns | 1.677 ns | 647.17 ns | 650.41 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 691.12 ns | 73.989 ns | 4.056 ns | 687.21 ns | 695.31 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  59.00 ns |  2.854 ns | 0.156 ns |  58.85 ns |  59.16 ns | 0.0014 |     120 B |
