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
| SystemTextJson          | Seria(...)Class [29] | 608.79 ns | 60.364 ns | 3.309 ns | 605.22 ns | 611.75 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 642.12 ns | 39.065 ns | 2.141 ns | 639.76 ns | 643.93 ns | 0.0277 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  43.79 ns |  4.915 ns | 0.269 ns |  43.52 ns |  44.06 ns | 0.0072 |     120 B |
