```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 607.65 ns |  59.19 ns | 3.245 ns | 605.20 ns | 611.33 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 644.12 ns | 107.29 ns | 5.881 ns | 638.87 ns | 650.48 ns | 0.0277 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  43.58 ns |  10.48 ns | 0.575 ns |  42.96 ns |  44.10 ns | 0.0072 |     120 B |
