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
| StringSplitNoAlloc | 1      |   893.8 ns | 120.1 ns |  6.58 ns |   887.5 ns |   900.6 ns |      - |         - |
| StringSplit        | 1      | 1,488.8 ns | 350.2 ns | 19.20 ns | 1,477.0 ns | 1,510.9 ns | 0.0381 |    3208 B |
