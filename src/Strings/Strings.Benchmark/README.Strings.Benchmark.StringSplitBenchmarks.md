```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error     | StdDev  | Min        | Max        | Gen0   | Allocated |
|------------------- |------- |-----------:|----------:|--------:|-----------:|-----------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   899.2 ns | 180.67 ns | 9.90 ns |   892.6 ns |   910.6 ns |      - |         - |
| StringSplit        | 1      | 1,529.8 ns |  11.26 ns | 0.62 ns | 1,529.2 ns | 1,530.4 ns | 0.0381 |    3208 B |
