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
| StringSplitNoAlloc | .NET 8.0 | 1      |   843.6 ns |  13.97 ns |  0.77 ns |   842.9 ns |   844.4 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,515.4 ns | 275.32 ns | 15.09 ns | 1,501.8 ns | 1,531.6 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   895.7 ns |  41.60 ns |  2.28 ns |   893.5 ns |   898.0 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,457.6 ns | 256.51 ns | 14.06 ns | 1,443.0 ns | 1,471.1 ns | 0.1907 | 0.0019 |    3208 B |
