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
| StringSplitNoAlloc | .NET 8.0 | 1      |   838.0 ns |  10.01 ns |  0.55 ns |   837.4 ns |   838.5 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,382.4 ns | 200.05 ns | 10.97 ns | 1,370.3 ns | 1,391.8 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   852.1 ns | 108.58 ns |  5.95 ns |   846.8 ns |   858.6 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,379.0 ns | 359.32 ns | 19.70 ns | 1,358.9 ns | 1,398.3 ns | 0.1907 | 0.0019 |    3208 B |
