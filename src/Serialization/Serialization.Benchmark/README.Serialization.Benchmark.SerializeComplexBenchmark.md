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
| SystemTextJson          | Seria(...)Class [29] | 640.71 ns | 20.186 ns | 1.106 ns | 639.73 ns | 641.91 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 698.55 ns | 37.872 ns | 2.076 ns | 696.17 ns | 699.99 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.49 ns |  1.532 ns | 0.084 ns |  58.40 ns |  58.55 ns | 0.0014 |     120 B |
