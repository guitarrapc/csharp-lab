```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.93 ns** | **1.475 ns** | **0.081 ns** |  **61.89 ns** |  **62.03 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.10 ns | 0.255 ns | 0.014 ns |  57.09 ns |  57.12 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.64 ns** | **5.935 ns** | **0.325 ns** | **119.43 ns** | **120.01 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.01 ns | 0.527 ns | 0.029 ns | 113.98 ns | 114.04 ns |      - |         - |
