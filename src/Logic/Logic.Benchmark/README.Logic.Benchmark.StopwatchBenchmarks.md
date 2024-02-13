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
| **Stopwatch**      | **1**      |  **60.37 ns** | **11.65 ns** | **0.639 ns** |  **59.94 ns** |  **61.10 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  54.92 ns | 10.03 ns | 0.550 ns |  54.58 ns |  55.55 ns |      - |         - |
| **Stopwatch**      | **10**     | **310.03 ns** | **77.01 ns** | **4.221 ns** | **305.89 ns** | **314.33 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 302.65 ns | 64.23 ns | 3.521 ns | 299.22 ns | 306.26 ns |      - |         - |
