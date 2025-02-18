```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data                 | Mean     | Error     | StdDev    | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------- |--------------------- |---------:|----------:|----------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | Seria(...)Class [28] | 3.593 μs | 0.1765 μs | 0.0097 μs | 3.583 μs | 3.602 μs | 0.1259 |   2.07 KB |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)Class [28] | 3.039 μs | 0.1703 μs | 0.0093 μs | 3.030 μs | 3.049 μs | 0.1335 |    2.2 KB |
| SystemTextJson          | .NET 9.0 | Seria(...)Class [28] | 3.443 μs | 0.1509 μs | 0.0083 μs | 3.435 μs | 3.452 μs | 0.1259 |   2.07 KB |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)Class [28] | 2.802 μs | 0.0921 μs | 0.0050 μs | 2.797 μs | 2.807 μs | 0.1335 |    2.2 KB |
