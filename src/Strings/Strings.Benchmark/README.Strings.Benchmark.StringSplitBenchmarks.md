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
| StringSplitNoAlloc | .NET 8.0 | 1      |   841.2 ns |  19.40 ns |  1.06 ns |   840.1 ns |   842.2 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,388.2 ns |  91.99 ns |  5.04 ns | 1,382.5 ns | 1,392.0 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   854.6 ns |  33.97 ns |  1.86 ns |   852.5 ns |   856.0 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,371.3 ns | 202.44 ns | 11.10 ns | 1,360.6 ns | 1,382.7 ns | 0.1907 | 0.0019 |    3208 B |
