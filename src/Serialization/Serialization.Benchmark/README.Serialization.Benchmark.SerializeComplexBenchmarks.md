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
| SystemTextJson          | Seria(...)Class [29] | 611.29 ns | 13.122 ns | 0.719 ns | 610.85 ns | 612.12 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 653.62 ns | 67.774 ns | 3.715 ns | 650.91 ns | 657.86 ns | 0.0277 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  44.94 ns |  9.537 ns | 0.523 ns |  44.57 ns |  45.53 ns | 0.0072 |     120 B |
