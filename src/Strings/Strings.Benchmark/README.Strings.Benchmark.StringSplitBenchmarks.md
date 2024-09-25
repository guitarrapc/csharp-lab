```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error    | StdDev  | Min        | Max        | Gen0   | Allocated |
|------------------- |------- |-----------:|---------:|--------:|-----------:|-----------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   848.6 ns | 110.6 ns | 6.06 ns |   844.5 ns |   855.6 ns |      - |         - |
| StringSplit        | 1      | 1,542.9 ns | 164.8 ns | 9.03 ns | 1,534.1 ns | 1,552.1 ns | 0.0381 |    3208 B |
