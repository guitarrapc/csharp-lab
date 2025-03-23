```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   839.9 ns |  13.44 ns |  0.74 ns |   839.3 ns |   840.7 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,474.4 ns | 474.98 ns | 26.04 ns | 1,451.4 ns | 1,502.7 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   851.2 ns |   0.73 ns |  0.04 ns |   851.1 ns |   851.2 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,375.7 ns | 292.60 ns | 16.04 ns | 1,366.1 ns | 1,394.2 ns | 0.1907 | 0.0019 |    3208 B |
