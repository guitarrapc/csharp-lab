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
| SystemTextJson          | .NET 8.0 | Seria(...)Class [28] | 3.756 μs | 0.1610 μs | 0.0088 μs | 3.751 μs | 3.766 μs | 0.1259 |   2.07 KB |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)Class [28] | 2.997 μs | 0.0634 μs | 0.0035 μs | 2.993 μs | 3.000 μs | 0.1335 |    2.2 KB |
| SystemTextJson          | .NET 9.0 | Seria(...)Class [28] | 3.313 μs | 1.5336 μs | 0.0841 μs | 3.251 μs | 3.409 μs | 0.1259 |   2.07 KB |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)Class [28] | 2.861 μs | 0.4688 μs | 0.0257 μs | 2.834 μs | 2.885 μs | 0.1335 |    2.2 KB |
