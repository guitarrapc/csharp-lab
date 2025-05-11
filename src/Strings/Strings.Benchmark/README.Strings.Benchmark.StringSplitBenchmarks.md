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
| StringSplitNoAlloc | .NET 8.0 | 1      |   852.2 ns | 251.71 ns | 13.80 ns |   843.3 ns |   868.1 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,506.0 ns | 257.15 ns | 14.10 ns | 1,493.6 ns | 1,521.3 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   852.0 ns |  34.52 ns |  1.89 ns |   850.3 ns |   854.1 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,354.6 ns | 179.15 ns |  9.82 ns | 1,344.1 ns | 1,363.5 ns | 0.1907 | 0.0019 |    3208 B |
