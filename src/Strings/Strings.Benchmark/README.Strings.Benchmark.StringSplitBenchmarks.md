```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error    | StdDev   | Min        | Max        | Gen0   | Allocated |
|------------------- |------- |-----------:|---------:|---------:|-----------:|-----------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   841.9 ns | 121.1 ns |  6.64 ns |   834.4 ns |   847.2 ns |      - |         - |
| StringSplit        | 1      | 1,526.9 ns | 194.8 ns | 10.68 ns | 1,520.5 ns | 1,539.2 ns | 0.0381 |    3208 B |
