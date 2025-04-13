```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | json                | Mean     | Error    | StdDev   | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |---------:|---------:|---------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | {&quot;A&quot;(...)e&quot;}} [891] | 18.95 μs | 1.783 μs | 0.098 μs | 18.86 μs | 19.05 μs | 0.1831 |   3.22 KB |
| SystemTextJsonSourceGen | .NET 8.0 | {&quot;A&quot;(...)e&quot;}} [891] | 18.32 μs | 1.183 μs | 0.065 μs | 18.26 μs | 18.39 μs | 0.1831 |   3.22 KB |
| SystemTextJson          | .NET 9.0 | {&quot;A&quot;(...)e&quot;}} [891] | 18.94 μs | 0.793 μs | 0.043 μs | 18.89 μs | 18.96 μs | 0.1831 |   3.22 KB |
| SystemTextJsonSourceGen | .NET 9.0 | {&quot;A&quot;(...)e&quot;}} [891] | 18.31 μs | 0.497 μs | 0.027 μs | 18.29 μs | 18.34 μs | 0.1831 |   3.22 KB |
