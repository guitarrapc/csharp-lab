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
| StringSplitNoAlloc | .NET 8.0 | 1      |   846.4 ns |  24.31 ns |  1.33 ns |   845.3 ns |   847.9 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,474.9 ns | 432.50 ns | 23.71 ns | 1,449.1 ns | 1,495.6 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   852.8 ns |  82.80 ns |  4.54 ns |   849.9 ns |   858.0 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,373.6 ns | 351.09 ns | 19.24 ns | 1,357.4 ns | 1,394.9 ns | 0.1907 | 0.0019 |    3208 B |
