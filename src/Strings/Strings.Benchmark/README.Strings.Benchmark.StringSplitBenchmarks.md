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
| StringSplitNoAlloc | .NET 8.0 | 1      |   847.9 ns |  40.78 ns |  2.24 ns |   845.5 ns |   850.0 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,396.7 ns |  56.14 ns |  3.08 ns | 1,393.2 ns | 1,399.0 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   852.5 ns |   6.50 ns |  0.36 ns |   852.1 ns |   852.8 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,315.5 ns | 272.74 ns | 14.95 ns | 1,306.6 ns | 1,332.8 ns | 0.1907 | 0.0019 |    3208 B |
