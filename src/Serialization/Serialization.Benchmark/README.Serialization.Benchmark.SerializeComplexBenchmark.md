```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 642.00 ns |  27.534 ns |  1.509 ns | 640.96 ns | 643.73 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 711.77 ns | 183.519 ns | 10.059 ns | 704.03 ns | 723.14 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.99 ns |   2.099 ns |  0.115 ns |  57.87 ns |  58.10 ns | 0.0014 |     120 B |
