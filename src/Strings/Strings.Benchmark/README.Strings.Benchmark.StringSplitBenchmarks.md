```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Allocated |
|------------------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   835.5 ns |  42.83 ns |  2.35 ns |   832.8 ns |   837.3 ns |      - |         - |
| StringSplit        | 1      | 1,503.3 ns | 220.64 ns | 12.09 ns | 1,495.2 ns | 1,517.2 ns | 0.0381 |    3208 B |
