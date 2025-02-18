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
| StringSplitNoAlloc | .NET 8.0 | 1      |   870.5 ns | 146.62 ns |  8.04 ns |   865.1 ns |   879.7 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,435.3 ns |  40.24 ns |  2.21 ns | 1,432.9 ns | 1,437.2 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   853.6 ns | 111.39 ns |  6.11 ns |   850.0 ns |   860.6 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,394.2 ns | 255.70 ns | 14.02 ns | 1,382.3 ns | 1,409.6 ns | 0.1907 | 0.0019 |    3208 B |
