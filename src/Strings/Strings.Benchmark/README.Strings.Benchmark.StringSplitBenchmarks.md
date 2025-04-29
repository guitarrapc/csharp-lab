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
| StringSplitNoAlloc | .NET 8.0 | 1      |   848.5 ns |  15.03 ns |  0.82 ns |   847.7 ns |   849.3 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,438.6 ns | 239.76 ns | 13.14 ns | 1,425.7 ns | 1,452.0 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   851.6 ns |  89.53 ns |  4.91 ns |   846.0 ns |   855.2 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,284.4 ns |  64.92 ns |  3.56 ns | 1,281.2 ns | 1,288.2 ns | 0.1907 | 0.0019 |    3208 B |
