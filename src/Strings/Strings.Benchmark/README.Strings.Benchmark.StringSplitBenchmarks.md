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
| StringSplitNoAlloc | .NET 8.0 | 1      |   840.6 ns |  33.31 ns |  1.83 ns |   838.6 ns |   842.3 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,469.1 ns | 207.70 ns | 11.38 ns | 1,461.3 ns | 1,482.2 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   850.7 ns |  15.80 ns |  0.87 ns |   849.7 ns |   851.4 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,334.9 ns |  74.33 ns |  4.07 ns | 1,331.3 ns | 1,339.3 ns | 0.1907 | 0.0019 |    3208 B |
