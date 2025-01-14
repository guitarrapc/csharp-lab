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
| SystemTextJson          | Seria(...)Class [28] | 3.340 μs | 0.0197 μs | 0.0011 μs | 3.339 μs | 3.342 μs | 0.1259 |   2.07 KB |
| SystemTextJsonSourceGen | Seria(...)Class [28] | 2.950 μs | 0.0780 μs | 0.0043 μs | 2.945 μs | 2.953 μs | 0.1335 |    2.2 KB |
