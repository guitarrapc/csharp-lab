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
| SystemTextJson          | Seria(...)Class [29] | 640.88 ns | 25.828 ns | 1.416 ns | 639.75 ns | 642.47 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 686.96 ns | 10.106 ns | 0.554 ns | 686.32 ns | 687.32 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.74 ns |  1.362 ns | 0.075 ns |  57.66 ns |  57.80 ns | 0.0014 |     120 B |
