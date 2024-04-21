```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Allocated |
|------------------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   830.5 ns |   5.80 ns |  0.32 ns |   830.1 ns |   830.7 ns |      - |         - |
| StringSplit        | 1      | 1,520.6 ns | 723.38 ns | 39.65 ns | 1,494.5 ns | 1,566.2 ns | 0.0381 |    3208 B |
