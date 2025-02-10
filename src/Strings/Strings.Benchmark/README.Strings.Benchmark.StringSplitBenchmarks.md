```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error    | StdDev  | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |------- |-----------:|---------:|--------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   894.0 ns | 35.84 ns | 1.96 ns |   892.8 ns |   896.3 ns |      - |      - |         - |
| StringSplit        | 1      | 1,392.0 ns | 29.08 ns | 1.59 ns | 1,390.2 ns | 1,393.3 ns | 0.1907 | 0.0019 |    3208 B |
