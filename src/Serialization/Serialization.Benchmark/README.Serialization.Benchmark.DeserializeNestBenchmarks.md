```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | json                | Mean     | Error     | StdDev   | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |---------:|----------:|---------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | {&quot;A&quot;(...)e&quot;}} [891] | 18.46 μs |  0.960 μs | 0.053 μs | 18.43 μs | 18.52 μs | 0.1831 |   3.22 KB |
| SystemTextJsonSourceGen | .NET 8.0 | {&quot;A&quot;(...)e&quot;}} [891] | 17.93 μs |  0.343 μs | 0.019 μs | 17.92 μs | 17.95 μs | 0.1831 |   3.22 KB |
| SystemTextJson          | .NET 9.0 | {&quot;A&quot;(...)e&quot;}} [891] | 18.94 μs | 13.217 μs | 0.724 μs | 18.50 μs | 19.77 μs | 0.1831 |   3.22 KB |
| SystemTextJsonSourceGen | .NET 9.0 | {&quot;A&quot;(...)e&quot;}} [891] | 17.60 μs |  1.992 μs | 0.109 μs | 17.54 μs | 17.73 μs | 0.1831 |   3.22 KB |
