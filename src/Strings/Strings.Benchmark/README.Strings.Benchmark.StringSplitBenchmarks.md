```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error    | StdDev   | Min        | Max        | Gen0   | Allocated |
|------------------- |------- |-----------:|---------:|---------:|-----------:|-----------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   859.8 ns | 438.5 ns | 24.03 ns |   842.6 ns |   887.2 ns |      - |         - |
| StringSplit        | 1      | 1,485.7 ns | 179.9 ns |  9.86 ns | 1,475.9 ns | 1,495.6 ns | 0.0381 |    3208 B |
