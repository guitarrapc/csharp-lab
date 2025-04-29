```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   840.7 ns |  26.07 ns |  1.43 ns |   839.2 ns |   842.1 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,536.6 ns | 550.91 ns | 30.20 ns | 1,501.8 ns | 1,556.5 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   856.7 ns |  76.74 ns |  4.21 ns |   854.2 ns |   861.5 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,312.7 ns | 178.28 ns |  9.77 ns | 1,302.7 ns | 1,322.3 ns | 0.1907 | 0.0019 |    3208 B |
