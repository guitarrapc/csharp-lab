```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **60.69 ns** |  **3.261 ns** | **0.179 ns** |  **60.49 ns** |  **60.83 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.88 ns |  0.153 ns | 0.008 ns |  55.87 ns |  55.89 ns |      - |         - |
| **Stopwatch**      | **10**     | **317.03 ns** | **10.041 ns** | **0.550 ns** | **316.41 ns** | **317.45 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.54 ns |  4.243 ns | 0.233 ns | 308.40 ns | 308.81 ns |      - |         - |
