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
| SystemTextJson          | Seria(...)Class [29] | 642.55 ns | 16.413 ns | 0.900 ns | 641.98 ns | 643.59 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 707.65 ns | 31.955 ns | 1.752 ns | 706.59 ns | 709.67 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  59.51 ns |  0.635 ns | 0.035 ns |  59.48 ns |  59.55 ns | 0.0014 |     120 B |
