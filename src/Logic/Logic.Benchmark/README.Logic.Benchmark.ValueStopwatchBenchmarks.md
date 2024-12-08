```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **62.29 ns** |  **2.203 ns** | **0.121 ns** |  **62.21 ns** |  **62.43 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.59 ns | 12.212 ns | 0.669 ns |  57.14 ns |  58.36 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.63 ns** |  **5.056 ns** | **0.277 ns** | **119.46 ns** | **119.95 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.67 ns |  0.960 ns | 0.053 ns | 114.61 ns | 114.71 ns |      - |         - |
