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
| StringSplitNoAlloc | .NET 8.0 | 1      |   839.6 ns |  27.25 ns |  1.49 ns |   838.2 ns |   841.2 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,470.7 ns | 465.45 ns | 25.51 ns | 1,447.0 ns | 1,497.7 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   852.8 ns |  38.27 ns |  2.10 ns |   850.8 ns |   855.0 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,367.3 ns | 243.38 ns | 13.34 ns | 1,352.1 ns | 1,376.9 ns | 0.1907 | 0.0019 |    3208 B |
