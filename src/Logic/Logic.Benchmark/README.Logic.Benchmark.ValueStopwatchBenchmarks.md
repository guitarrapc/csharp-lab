```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.28 ns** | **2.105 ns** | **0.115 ns** |  **61.21 ns** |  **61.42 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.17 ns | 0.981 ns | 0.054 ns |  57.12 ns |  57.23 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.60 ns** | **4.407 ns** | **0.242 ns** | **119.45 ns** | **119.88 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.63 ns | 0.308 ns | 0.017 ns | 114.61 ns | 114.65 ns |      - |         - |
