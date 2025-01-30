```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error     | StdDev    | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|----------:|----------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [28] | 3.285 μs | 0.0414 μs | 0.0023 μs | 3.283 μs | 3.287 μs | 0.1259 |   2.07 KB |
| SystemTextJsonSourceGen | Seria(...)Class [28] | 2.806 μs | 0.0979 μs | 0.0054 μs | 2.800 μs | 2.810 μs | 0.1335 |    2.2 KB |
