```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error     | StdDev  | Min        | Max        | Gen0   | Allocated |
|------------------- |------- |-----------:|----------:|--------:|-----------:|-----------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   828.4 ns |  23.84 ns | 1.31 ns |   827.0 ns |   829.6 ns |      - |         - |
| StringSplit        | 1      | 1,461.6 ns | 115.39 ns | 6.32 ns | 1,456.6 ns | 1,468.8 ns | 0.0381 |    3208 B |
