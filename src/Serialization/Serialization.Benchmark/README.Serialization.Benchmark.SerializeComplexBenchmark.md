```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 684.50 ns | 677.825 ns | 37.154 ns | 662.09 ns | 727.39 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 696.70 ns |  21.415 ns |  1.174 ns | 695.91 ns | 698.04 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  61.29 ns |   7.536 ns |  0.413 ns |  60.84 ns |  61.64 ns | 0.0014 |     120 B |
