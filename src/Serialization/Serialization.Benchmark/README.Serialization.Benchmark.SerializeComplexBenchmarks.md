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
| SystemTextJson          | Seria(...)Class [29] | 650.29 ns | 49.892 ns | 2.735 ns | 648.17 ns | 653.37 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 695.87 ns | 38.523 ns | 2.112 ns | 694.53 ns | 698.31 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  60.57 ns |  1.897 ns | 0.104 ns |  60.45 ns |  60.64 ns | 0.0014 |     120 B |
