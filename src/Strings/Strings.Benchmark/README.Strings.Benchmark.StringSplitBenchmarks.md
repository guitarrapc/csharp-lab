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
| StringSplitNoAlloc | 1      |   876.9 ns | 251.9 ns | 13.81 ns |   864.3 ns |   891.7 ns |      - |         - |
| StringSplit        | 1      | 1,692.3 ns | 114.2 ns |  6.26 ns | 1,685.2 ns | 1,697.1 ns | 0.0381 |    3208 B |
