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
| StringSplitNoAlloc | .NET 8.0 | 1      |   846.5 ns |  22.08 ns |  1.21 ns |   845.6 ns |   847.9 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,531.5 ns |  17.53 ns |  0.96 ns | 1,530.8 ns | 1,532.6 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   851.5 ns |  12.39 ns |  0.68 ns |   850.8 ns |   852.1 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,341.7 ns | 312.56 ns | 17.13 ns | 1,328.6 ns | 1,361.1 ns | 0.1907 | 0.0019 |    3208 B |
