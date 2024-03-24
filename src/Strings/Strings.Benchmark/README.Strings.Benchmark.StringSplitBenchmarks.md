```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Allocated |
|------------------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   825.3 ns |    30.35 ns |  1.66 ns |   823.4 ns |   826.6 ns |      - |         - |
| StringSplit        | 1      | 1,529.0 ns | 1,124.34 ns | 61.63 ns | 1,483.1 ns | 1,599.0 ns | 0.0381 |    3208 B |
