```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   851.6 ns |  51.51 ns |  2.82 ns |   849.7 ns |   854.8 ns |      - |      - |         - |
| StringSplit        | 1      | 1,340.7 ns | 310.64 ns | 17.03 ns | 1,328.1 ns | 1,360.0 ns | 0.1907 | 0.0019 |    3208 B |
