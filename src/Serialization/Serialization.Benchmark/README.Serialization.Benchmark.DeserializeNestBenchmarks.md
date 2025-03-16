```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | json                | Mean     | Error    | StdDev   | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |---------:|---------:|---------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | {&quot;A&quot;(...)e&quot;}} [891] | 18.83 μs | 0.527 μs | 0.029 μs | 18.80 μs | 18.86 μs | 0.1831 |   3.22 KB |
| SystemTextJsonSourceGen | .NET 8.0 | {&quot;A&quot;(...)e&quot;}} [891] | 18.42 μs | 1.456 μs | 0.080 μs | 18.37 μs | 18.52 μs | 0.1831 |   3.22 KB |
| SystemTextJson          | .NET 9.0 | {&quot;A&quot;(...)e&quot;}} [891] | 18.91 μs | 1.792 μs | 0.098 μs | 18.81 μs | 19.01 μs | 0.1831 |   3.22 KB |
| SystemTextJsonSourceGen | .NET 9.0 | {&quot;A&quot;(...)e&quot;}} [891] | 18.27 μs | 1.689 μs | 0.093 μs | 18.18 μs | 18.36 μs | 0.1831 |   3.22 KB |
