```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error     | StdDev  | Min        | Max        | Gen0   | Allocated |
|------------------- |------- |-----------:|----------:|--------:|-----------:|-----------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   829.9 ns |  21.56 ns | 1.18 ns |   828.6 ns |   831.0 ns |      - |         - |
| StringSplit        | 1      | 1,512.9 ns | 106.64 ns | 5.85 ns | 1,506.8 ns | 1,518.4 ns | 0.0381 |    3208 B |
