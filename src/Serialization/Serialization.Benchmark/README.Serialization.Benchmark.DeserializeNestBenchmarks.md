```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | json                | Mean     | Error    | StdDev   | Min      | Max      | Gen0   | Allocated |
|------------------------ |-------------------- |---------:|---------:|---------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | {&quot;A&quot;(...)e&quot;}} [891] | 18.66 μs | 1.311 μs | 0.072 μs | 18.61 μs | 18.74 μs | 0.1831 |   3.22 KB |
| SystemTextJsonSourceGen | {&quot;A&quot;(...)e&quot;}} [891] | 18.27 μs | 0.843 μs | 0.046 μs | 18.23 μs | 18.32 μs | 0.1831 |   3.22 KB |
