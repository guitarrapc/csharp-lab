```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   846.0 ns |  30.05 ns |  1.65 ns |   844.8 ns |   847.8 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,473.3 ns | 179.22 ns |  9.82 ns | 1,465.7 ns | 1,484.4 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   850.6 ns |  10.25 ns |  0.56 ns |   850.0 ns |   851.1 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,431.2 ns | 303.94 ns | 16.66 ns | 1,416.9 ns | 1,449.5 ns | 0.1907 | 0.0019 |    3208 B |
