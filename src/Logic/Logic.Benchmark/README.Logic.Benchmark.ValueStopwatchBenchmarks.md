```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **60.33 ns** | **12.594 ns** | **0.690 ns** |  **59.71 ns** |  **61.07 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.81 ns | 10.706 ns | 0.587 ns |  55.13 ns |  56.15 ns |      - |         - |
| **Stopwatch**      | **3**      | **116.76 ns** | **28.741 ns** | **1.575 ns** | **115.79 ns** | **118.58 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 109.49 ns |  8.143 ns | 0.446 ns | 109.02 ns | 109.91 ns |      - |         - |
