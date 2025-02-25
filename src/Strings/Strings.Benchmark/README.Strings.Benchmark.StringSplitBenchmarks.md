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
| StringSplitNoAlloc | .NET 8.0 | 1      |   839.5 ns |   7.98 ns |  0.44 ns |   839.0 ns |   839.8 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,496.9 ns | 199.20 ns | 10.92 ns | 1,489.5 ns | 1,509.4 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   856.6 ns |  85.03 ns |  4.66 ns |   851.7 ns |   860.9 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,364.0 ns | 194.33 ns | 10.65 ns | 1,352.6 ns | 1,373.7 ns | 0.1907 | 0.0019 |    3208 B |
