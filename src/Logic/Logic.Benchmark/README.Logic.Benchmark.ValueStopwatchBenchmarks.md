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
| **Stopwatch**      | **1**      |  **61.44 ns** |  **5.624 ns** | **0.308 ns** |  **61.26 ns** |  **61.79 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.15 ns |  0.629 ns | 0.034 ns |  57.11 ns |  57.18 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.55 ns** |  **4.575 ns** | **0.251 ns** | **119.39 ns** | **119.84 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.56 ns | 18.055 ns | 0.990 ns | 113.96 ns | 115.70 ns |      - |         - |
