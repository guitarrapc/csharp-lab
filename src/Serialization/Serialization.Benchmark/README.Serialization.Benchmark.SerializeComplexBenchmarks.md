```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 621.47 ns | 45.07 ns | 2.470 ns | 619.60 ns | 624.27 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 657.17 ns | 23.56 ns | 1.291 ns | 655.99 ns | 658.55 ns | 0.0277 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  47.65 ns | 34.62 ns | 1.897 ns |  46.23 ns |  49.80 ns | 0.0072 |     120 B |
