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
| SystemTextJson          | Seria(...)Class [29] | 645.01 ns |  5.319 ns | 0.292 ns | 644.76 ns | 645.33 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 699.35 ns | 28.966 ns | 1.588 ns | 698.22 ns | 701.16 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.98 ns |  3.032 ns | 0.166 ns |  58.82 ns |  59.16 ns | 0.0014 |     120 B |
