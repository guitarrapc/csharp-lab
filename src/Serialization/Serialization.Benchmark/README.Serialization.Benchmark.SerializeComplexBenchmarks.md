```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 640.62 ns |  15.757 ns |  0.864 ns | 640.09 ns | 641.61 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 723.28 ns | 416.204 ns | 22.814 ns | 710.07 ns | 749.62 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  60.52 ns |   3.674 ns |  0.201 ns |  60.32 ns |  60.73 ns | 0.0014 |     120 B |
