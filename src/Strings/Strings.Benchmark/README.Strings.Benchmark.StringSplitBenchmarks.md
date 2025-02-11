```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   839.0 ns |  23.09 ns |  1.27 ns |   837.9 ns |   840.4 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,460.5 ns | 336.55 ns | 18.45 ns | 1,442.8 ns | 1,479.6 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   849.4 ns |   8.60 ns |  0.47 ns |   848.9 ns |   849.8 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,374.0 ns | 465.38 ns | 25.51 ns | 1,345.8 ns | 1,395.5 ns | 0.1907 | 0.0019 |    3208 B |
