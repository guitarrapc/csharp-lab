```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   846.8 ns |    14.93 ns |  0.82 ns |   845.9 ns |   847.3 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,445.7 ns |   909.85 ns | 49.87 ns | 1,393.4 ns | 1,492.7 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   850.1 ns |    19.61 ns |  1.07 ns |   849.4 ns |   851.4 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,474.9 ns | 1,304.28 ns | 71.49 ns | 1,427.1 ns | 1,557.1 ns | 0.1907 | 0.0019 |    3208 B |
