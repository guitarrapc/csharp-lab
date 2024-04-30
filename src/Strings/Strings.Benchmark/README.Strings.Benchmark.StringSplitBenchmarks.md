```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error     | StdDev  | Min        | Max        | Gen0   | Allocated |
|------------------- |------- |-----------:|----------:|--------:|-----------:|-----------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   824.6 ns |  19.95 ns | 1.09 ns |   823.6 ns |   825.7 ns |      - |         - |
| StringSplit        | 1      | 1,483.7 ns | 121.25 ns | 6.65 ns | 1,476.0 ns | 1,488.2 ns | 0.0381 |    3208 B |
