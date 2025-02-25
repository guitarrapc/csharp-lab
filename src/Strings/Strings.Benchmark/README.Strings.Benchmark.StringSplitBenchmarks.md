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
| StringSplitNoAlloc | .NET 8.0 | 1      |   844.5 ns |     8.81 ns |  0.48 ns |   844.2 ns |   845.1 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,482.6 ns |   899.94 ns | 49.33 ns | 1,429.2 ns | 1,526.4 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   851.3 ns |    35.22 ns |  1.93 ns |   849.8 ns |   853.5 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,403.5 ns | 1,285.09 ns | 70.44 ns | 1,339.1 ns | 1,478.8 ns | 0.1907 | 0.0019 |    3208 B |
