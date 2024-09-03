```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|----------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 682.38 ns | 203.10 ns | 11.132 ns | 672.37 ns | 694.37 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 725.56 ns | 164.31 ns |  9.006 ns | 716.40 ns | 734.40 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  64.14 ns |  13.24 ns |  0.726 ns |  63.40 ns |  64.85 ns | 0.0014 |     120 B |
