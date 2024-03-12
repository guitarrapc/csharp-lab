```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 636.65 ns | 19.228 ns | 1.054 ns | 635.97 ns | 637.87 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 697.91 ns | 25.351 ns | 1.390 ns | 697.05 ns | 699.52 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.01 ns |  1.418 ns | 0.078 ns |  57.93 ns |  58.09 ns | 0.0014 |     120 B |
