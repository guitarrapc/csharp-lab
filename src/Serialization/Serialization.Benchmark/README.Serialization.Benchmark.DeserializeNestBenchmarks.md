```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | json                | Mean     | Error    | StdDev   | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |---------:|---------:|---------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | {&quot;A&quot;(...)e&quot;}} [891] | 19.01 μs | 1.275 μs | 0.070 μs | 18.94 μs | 19.08 μs | 0.1831 |   3.22 KB |
| SystemTextJsonSourceGen | .NET 8.0 | {&quot;A&quot;(...)e&quot;}} [891] | 18.49 μs | 4.195 μs | 0.230 μs | 18.33 μs | 18.75 μs | 0.1831 |   3.22 KB |
| SystemTextJson          | .NET 9.0 | {&quot;A&quot;(...)e&quot;}} [891] | 18.92 μs | 2.739 μs | 0.150 μs | 18.81 μs | 19.09 μs | 0.1831 |   3.22 KB |
| SystemTextJsonSourceGen | .NET 9.0 | {&quot;A&quot;(...)e&quot;}} [891] | 18.12 μs | 1.026 μs | 0.056 μs | 18.08 μs | 18.18 μs | 0.1831 |   3.22 KB |
