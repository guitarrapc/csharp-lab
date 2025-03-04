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
| StringSplitNoAlloc | .NET 8.0 | 1      |   846.4 ns |  31.59 ns |  1.73 ns |   845.0 ns |   848.3 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,421.8 ns | 252.16 ns | 13.82 ns | 1,408.3 ns | 1,435.9 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   853.1 ns |  79.06 ns |  4.33 ns |   850.5 ns |   858.1 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,339.3 ns | 327.80 ns | 17.97 ns | 1,320.8 ns | 1,356.7 ns | 0.1907 | 0.0019 |    3208 B |
