```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error    | StdDev  | Min        | Max        | Gen0   | Allocated |
|------------------- |------- |-----------:|---------:|--------:|-----------:|-----------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   827.2 ns | 33.73 ns | 1.85 ns |   825.6 ns |   829.2 ns |      - |         - |
| StringSplit        | 1      | 1,522.6 ns | 62.13 ns | 3.41 ns | 1,519.2 ns | 1,526.0 ns | 0.0381 |    3208 B |
