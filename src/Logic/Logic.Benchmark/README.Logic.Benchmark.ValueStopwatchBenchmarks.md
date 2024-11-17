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
| **Stopwatch**      | **1**      |  **62.27 ns** | **31.611 ns** | **1.733 ns** |  **61.22 ns** |  **64.27 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.20 ns |  1.586 ns | 0.087 ns |  57.14 ns |  57.30 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.49 ns** |  **4.601 ns** | **0.252 ns** | **119.28 ns** | **119.77 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.18 ns |  0.532 ns | 0.029 ns | 114.16 ns | 114.21 ns |      - |         - |
