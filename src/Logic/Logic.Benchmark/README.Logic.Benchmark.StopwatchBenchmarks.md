```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **60.02 ns** |  **3.521 ns** | **0.193 ns** |  **59.84 ns** |  **60.22 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.90 ns |  0.245 ns | 0.013 ns |  55.88 ns |  55.91 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.70 ns** | **12.114 ns** | **0.664 ns** | **316.22 ns** | **317.46 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.62 ns |  6.013 ns | 0.330 ns | 308.42 ns | 309.00 ns |      - |         - |
