```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   838.4 ns |  38.47 ns |  2.11 ns |   836.3 ns |   840.5 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,424.7 ns | 149.85 ns |  8.21 ns | 1,417.1 ns | 1,433.4 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   852.9 ns |   1.37 ns |  0.07 ns |   852.8 ns |   853.0 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,435.2 ns | 475.39 ns | 26.06 ns | 1,409.5 ns | 1,461.6 ns | 0.1907 | 0.0019 |    3208 B |
