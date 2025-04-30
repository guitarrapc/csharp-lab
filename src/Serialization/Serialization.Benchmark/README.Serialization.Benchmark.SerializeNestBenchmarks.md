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
| SystemTextJson          | .NET 8.0 | Seria(...)Class [28] | 3.499 μs | 0.4843 μs | 0.0265 μs | 3.479 μs | 3.529 μs | 0.1259 |   2.07 KB |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)Class [28] | 3.003 μs | 0.3324 μs | 0.0182 μs | 2.985 μs | 3.022 μs | 0.1335 |    2.2 KB |
| SystemTextJson          | .NET 9.0 | Seria(...)Class [28] | 3.211 μs | 0.2309 μs | 0.0127 μs | 3.197 μs | 3.221 μs | 0.1259 |   2.07 KB |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)Class [28] | 2.775 μs | 0.0787 μs | 0.0043 μs | 2.771 μs | 2.779 μs | 0.1335 |    2.2 KB |
