```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **62.01 ns** | **2.984 ns** | **0.164 ns** |  **61.82 ns** |  **62.11 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.56 ns | 1.292 ns | 0.071 ns |  57.49 ns |  57.63 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.55 ns** | **4.720 ns** | **0.259 ns** | **120.32 ns** | **120.83 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.64 ns | 1.781 ns | 0.098 ns | 114.58 ns | 114.75 ns |      - |         - |
