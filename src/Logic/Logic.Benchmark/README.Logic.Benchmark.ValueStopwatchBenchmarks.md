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
| **Stopwatch**      | **1**      |  **61.92 ns** | **3.693 ns** | **0.202 ns** |  **61.79 ns** |  **62.15 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.42 ns | 0.151 ns | 0.008 ns |  57.41 ns |  57.42 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.63 ns** | **5.349 ns** | **0.293 ns** | **120.42 ns** | **120.96 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.74 ns | 3.194 ns | 0.175 ns | 114.64 ns | 114.95 ns |      - |         - |
