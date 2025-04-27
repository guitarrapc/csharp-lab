```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data                 | Mean     | Error     | StdDev    | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------- |--------------------- |---------:|----------:|----------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | Seria(...)Class [28] | 3.597 μs | 0.2051 μs | 0.0112 μs | 3.589 μs | 3.609 μs | 0.1259 |   2.07 KB |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)Class [28] | 3.004 μs | 0.2856 μs | 0.0157 μs | 2.990 μs | 3.021 μs | 0.1335 |    2.2 KB |
| SystemTextJson          | .NET 9.0 | Seria(...)Class [28] | 3.292 μs | 0.2487 μs | 0.0136 μs | 3.281 μs | 3.307 μs | 0.1259 |   2.07 KB |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)Class [28] | 2.919 μs | 0.0757 μs | 0.0042 μs | 2.915 μs | 2.923 μs | 0.1335 |    2.2 KB |
