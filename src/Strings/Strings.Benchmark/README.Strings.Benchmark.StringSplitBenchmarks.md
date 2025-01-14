```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error    | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |------- |-----------:|---------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   882.9 ns | 496.9 ns | 27.24 ns |   851.5 ns |   899.6 ns |      - |      - |         - |
| StringSplit        | 1      | 1,352.2 ns | 428.9 ns | 23.51 ns | 1,338.3 ns | 1,379.3 ns | 0.1907 | 0.0019 |    3208 B |
