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
| SystemTextJson          | Seria(...)Class [29] | 611.79 ns | 28.09 ns | 1.540 ns | 610.63 ns | 613.53 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 646.38 ns | 68.91 ns | 3.777 ns | 642.22 ns | 649.59 ns | 0.0277 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  45.64 ns | 24.42 ns | 1.338 ns |  44.79 ns |  47.18 ns | 0.0072 |     120 B |
