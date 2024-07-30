```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 629.52 ns | 8.169 ns | 0.448 ns | 629.10 ns | 629.99 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 695.16 ns | 9.893 ns | 0.542 ns | 694.80 ns | 695.79 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.26 ns | 1.657 ns | 0.091 ns |  57.16 ns |  57.34 ns | 0.0014 |     120 B |
