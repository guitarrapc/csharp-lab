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
| **Stopwatch**      | **1**      |  **61.72 ns** |  **2.275 ns** | **0.125 ns** |  **61.60 ns** |  **61.85 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.13 ns |  0.850 ns | 0.047 ns |  57.10 ns |  57.18 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.52 ns** | **17.400 ns** | **0.954 ns** | **119.79 ns** | **121.60 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.10 ns |  2.751 ns | 0.151 ns | 113.97 ns | 114.27 ns |      - |         - |
