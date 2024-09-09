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
| SystemTextJson          | Seria(...)Class [29] | 653.88 ns | 41.810 ns | 2.292 ns | 652.46 ns | 656.52 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 712.98 ns |  6.043 ns | 0.331 ns | 712.61 ns | 713.24 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.90 ns |  2.855 ns | 0.156 ns |  58.79 ns |  59.08 ns | 0.0014 |     120 B |
