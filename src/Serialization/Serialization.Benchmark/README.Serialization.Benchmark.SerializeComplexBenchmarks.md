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
| SystemTextJson          | Seria(...)Class [29] | 669.94 ns | 32.320 ns | 1.772 ns | 668.16 ns | 671.70 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 698.66 ns | 28.365 ns | 1.555 ns | 696.87 ns | 699.57 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.85 ns |  0.715 ns | 0.039 ns |  58.80 ns |  58.88 ns | 0.0014 |     120 B |
