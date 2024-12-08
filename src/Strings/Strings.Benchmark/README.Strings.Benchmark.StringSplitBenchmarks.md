```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error    | StdDev  | Min        | Max        | Gen0   | Allocated |
|------------------- |------- |-----------:|---------:|--------:|-----------:|-----------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   837.3 ns | 70.61 ns | 3.87 ns |   833.4 ns |   841.1 ns |      - |         - |
| StringSplit        | 1      | 1,469.4 ns | 88.74 ns | 4.86 ns | 1,463.8 ns | 1,472.5 ns | 0.0381 |    3208 B |
