```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **62.39 ns** |  **2.058 ns** | **0.113 ns** |  **62.32 ns** |  **62.52 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.16 ns |  1.529 ns | 0.084 ns |  57.11 ns |  57.26 ns |      - |         - |
| **Stopwatch**      | **3**      | **121.14 ns** | **37.373 ns** | **2.049 ns** | **119.74 ns** | **123.49 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.64 ns |  0.121 ns | 0.007 ns | 114.64 ns | 114.65 ns |      - |         - |
