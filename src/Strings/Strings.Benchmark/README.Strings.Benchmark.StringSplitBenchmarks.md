```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   838.8 ns |  28.21 ns |  1.55 ns |   837.4 ns |   840.4 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,442.9 ns |  51.70 ns |  2.83 ns | 1,439.7 ns | 1,445.1 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   851.7 ns |   6.35 ns |  0.35 ns |   851.3 ns |   852.0 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,407.6 ns | 378.16 ns | 20.73 ns | 1,390.1 ns | 1,430.5 ns | 0.1907 | 0.0019 |    3208 B |
