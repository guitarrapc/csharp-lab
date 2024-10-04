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
| **Stopwatch**      | **1**      |  **62.31 ns** | **3.725 ns** | **0.204 ns** |  **62.11 ns** |  **62.52 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.54 ns | 1.348 ns | 0.074 ns |  57.46 ns |  57.61 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.73 ns** | **5.104 ns** | **0.280 ns** | **120.54 ns** | **121.05 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.64 ns | 0.743 ns | 0.041 ns | 114.61 ns | 114.69 ns |      - |         - |
