```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   846.7 ns |  39.18 ns |  2.15 ns |   844.2 ns |   848.2 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,403.8 ns | 138.45 ns |  7.59 ns | 1,396.3 ns | 1,411.5 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   850.5 ns |   2.13 ns |  0.12 ns |   850.4 ns |   850.7 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,534.5 ns | 934.92 ns | 51.25 ns | 1,475.4 ns | 1,567.0 ns | 0.1907 | 0.0019 |    3208 B |
