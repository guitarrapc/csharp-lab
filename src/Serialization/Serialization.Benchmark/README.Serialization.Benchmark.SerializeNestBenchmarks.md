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
| SystemTextJson          | .NET 8.0 | Seria(...)Class [28] | 3.570 μs | 0.2496 μs | 0.0137 μs | 3.559 μs | 3.585 μs | 0.1259 |   2.07 KB |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)Class [28] | 3.065 μs | 0.1956 μs | 0.0107 μs | 3.056 μs | 3.077 μs | 0.1335 |    2.2 KB |
| SystemTextJson          | .NET 9.0 | Seria(...)Class [28] | 3.518 μs | 0.2910 μs | 0.0159 μs | 3.506 μs | 3.536 μs | 0.1259 |   2.07 KB |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)Class [28] | 2.808 μs | 0.3768 μs | 0.0207 μs | 2.787 μs | 2.828 μs | 0.1335 |    2.2 KB |
