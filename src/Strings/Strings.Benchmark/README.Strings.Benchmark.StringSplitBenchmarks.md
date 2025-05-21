```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   886.3 ns |  15.19 ns |  0.83 ns |   885.5 ns |   887.1 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,464.9 ns | 476.43 ns | 26.11 ns | 1,448.7 ns | 1,495.1 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   849.5 ns |  12.75 ns |  0.70 ns |   848.7 ns |   849.9 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,299.0 ns | 244.06 ns | 13.38 ns | 1,284.9 ns | 1,311.5 ns | 0.1907 | 0.0019 |    3208 B |
