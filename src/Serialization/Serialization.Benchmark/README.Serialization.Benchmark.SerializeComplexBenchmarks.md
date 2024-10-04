```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 650.19 ns | 36.630 ns | 2.008 ns | 647.95 ns | 651.83 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 733.94 ns | 14.876 ns | 0.815 ns | 733.08 ns | 734.70 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.87 ns |  0.394 ns | 0.022 ns |  58.85 ns |  58.88 ns | 0.0014 |     120 B |
