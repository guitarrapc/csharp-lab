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
| **Stopwatch**      | **1**      |  **60.00 ns** | **2.219 ns** | **0.122 ns** |  **59.87 ns** |  **60.09 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.88 ns | 0.360 ns | 0.020 ns |  55.86 ns |  55.90 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.68 ns** | **8.057 ns** | **0.442 ns** | **316.38 ns** | **317.19 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.43 ns | 1.102 ns | 0.060 ns | 308.37 ns | 308.49 ns |      - |         - |
