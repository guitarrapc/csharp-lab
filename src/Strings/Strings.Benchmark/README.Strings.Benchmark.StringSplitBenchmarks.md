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
| StringSplitNoAlloc | .NET 8.0 | 1      |   839.4 ns |   2.44 ns |  0.13 ns |   839.2 ns |   839.5 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,457.8 ns | 131.30 ns |  7.20 ns | 1,451.4 ns | 1,465.6 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   851.5 ns |  26.90 ns |  1.47 ns |   849.8 ns |   852.6 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,378.7 ns | 496.26 ns | 27.20 ns | 1,350.8 ns | 1,405.1 ns | 0.1907 | 0.0019 |    3208 B |
