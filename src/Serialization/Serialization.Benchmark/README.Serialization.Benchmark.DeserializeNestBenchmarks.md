```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | json                | Mean     | Error    | StdDev   | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |---------:|---------:|---------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | {&quot;A&quot;(...)e&quot;}} [891] | 19.03 μs | 1.345 μs | 0.074 μs | 18.98 μs | 19.11 μs | 0.1831 |   3.22 KB |
| SystemTextJsonSourceGen | .NET 8.0 | {&quot;A&quot;(...)e&quot;}} [891] | 18.67 μs | 1.424 μs | 0.078 μs | 18.59 μs | 18.75 μs | 0.1831 |   3.22 KB |
| SystemTextJson          | .NET 9.0 | {&quot;A&quot;(...)e&quot;}} [891] | 18.74 μs | 0.754 μs | 0.041 μs | 18.70 μs | 18.77 μs | 0.1831 |   3.22 KB |
| SystemTextJsonSourceGen | .NET 9.0 | {&quot;A&quot;(...)e&quot;}} [891] | 18.23 μs | 0.331 μs | 0.018 μs | 18.21 μs | 18.24 μs | 0.1831 |   3.22 KB |
