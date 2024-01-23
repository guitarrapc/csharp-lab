```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **60.32 ns** | **6.071 ns** | **0.333 ns** |  **60.11 ns** |  **60.70 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.88 ns | 0.344 ns | 0.019 ns |  55.86 ns |  55.90 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.76 ns** | **9.468 ns** | **0.519 ns** | **316.43 ns** | **317.36 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.51 ns | 2.942 ns | 0.161 ns | 308.41 ns | 308.70 ns |      - |         - |
