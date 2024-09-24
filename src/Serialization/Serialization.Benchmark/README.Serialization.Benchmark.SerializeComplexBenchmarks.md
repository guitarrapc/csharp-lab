```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 647.81 ns | 30.68 ns | 1.681 ns | 645.89 ns | 648.99 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 697.91 ns | 27.55 ns | 1.510 ns | 696.19 ns | 699.02 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  61.54 ns | 32.47 ns | 1.780 ns |  60.41 ns |  63.59 ns | 0.0014 |     120 B |
