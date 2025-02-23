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
| StringSplitNoAlloc | .NET 8.0 | 1      |   840.0 ns |  27.50 ns |  1.51 ns |   838.4 ns |   841.3 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,569.3 ns | 268.32 ns | 14.71 ns | 1,559.2 ns | 1,586.1 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   852.0 ns |  56.77 ns |  3.11 ns |   850.1 ns |   855.6 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,491.2 ns | 226.94 ns | 12.44 ns | 1,478.4 ns | 1,503.2 ns | 0.1907 | 0.0019 |    3208 B |
