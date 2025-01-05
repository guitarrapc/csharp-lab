```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error     | StdDev    | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|----------:|----------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [28] | 3.312 μs | 0.3563 μs | 0.0195 μs | 3.301 μs | 3.335 μs | 0.1259 |   2.07 KB |
| SystemTextJsonSourceGen | Seria(...)Class [28] | 2.831 μs | 0.5275 μs | 0.0289 μs | 2.807 μs | 2.863 μs | 0.1335 |    2.2 KB |
