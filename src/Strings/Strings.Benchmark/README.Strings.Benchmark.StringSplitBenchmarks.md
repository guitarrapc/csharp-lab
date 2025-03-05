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
| StringSplitNoAlloc | .NET 8.0 | 1      |   841.1 ns |  65.85 ns |  3.61 ns |   838.4 ns |   845.2 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,494.2 ns | 550.83 ns | 30.19 ns | 1,459.4 ns | 1,512.5 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   851.8 ns |  58.02 ns |  3.18 ns |   849.8 ns |   855.5 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,366.0 ns | 114.54 ns |  6.28 ns | 1,360.4 ns | 1,372.8 ns | 0.1907 | 0.0019 |    3208 B |
