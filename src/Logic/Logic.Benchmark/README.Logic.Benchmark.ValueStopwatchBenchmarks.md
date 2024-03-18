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
| **Stopwatch**      | **1**      |  **61.42 ns** |  **1.957 ns** | **0.107 ns** |  **61.33 ns** |  **61.54 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  56.81 ns |  0.255 ns | 0.014 ns |  56.81 ns |  56.83 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.16 ns** | **15.341 ns** | **0.841 ns** | **119.64 ns** | **121.13 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.02 ns |  0.544 ns | 0.030 ns | 114.00 ns | 114.06 ns |      - |         - |
