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
| **Stopwatch**      | **1**      |  **61.53 ns** |  **1.959 ns** | **0.107 ns** |  **61.41 ns** |  **61.62 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.10 ns |  0.285 ns | 0.016 ns |  57.09 ns |  57.12 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.91 ns** | **10.521 ns** | **0.577 ns** | **119.43 ns** | **120.55 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.99 ns |  0.305 ns | 0.017 ns | 113.97 ns | 114.01 ns |      - |         - |
