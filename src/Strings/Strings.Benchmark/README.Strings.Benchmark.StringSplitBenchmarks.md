```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Allocated |
|------------------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   888.1 ns |  36.20 ns |  1.98 ns |   886.2 ns |   890.1 ns |      - |         - |
| StringSplit        | 1      | 1,523.8 ns | 240.25 ns | 13.17 ns | 1,509.3 ns | 1,535.1 ns | 0.0381 |    3208 B |
