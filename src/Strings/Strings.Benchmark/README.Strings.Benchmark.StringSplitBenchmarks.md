```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error    | StdDev  | Min        | Max        | Gen0   | Allocated |
|------------------- |------- |-----------:|---------:|--------:|-----------:|-----------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   846.7 ns | 29.16 ns | 1.60 ns |   845.2 ns |   848.4 ns |      - |         - |
| StringSplit        | 1      | 1,365.2 ns | 36.45 ns | 2.00 ns | 1,363.4 ns | 1,367.3 ns | 0.0381 |    3208 B |
