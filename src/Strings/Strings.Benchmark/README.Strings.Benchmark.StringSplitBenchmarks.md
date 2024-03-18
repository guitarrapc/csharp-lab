```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error    | StdDev   | Min        | Max        | Gen0   | Allocated |
|------------------- |------- |-----------:|---------:|---------:|-----------:|-----------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   833.4 ns | 118.6 ns |  6.50 ns |   829.1 ns |   840.8 ns |      - |         - |
| StringSplit        | 1      | 1,560.0 ns | 956.3 ns | 52.42 ns | 1,503.8 ns | 1,607.6 ns | 0.0381 |    3208 B |
