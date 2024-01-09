```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **60.14 ns** |  **4.943 ns** | **0.271 ns** |  **59.94 ns** |  **60.45 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.87 ns |  0.112 ns | 0.006 ns |  55.86 ns |  55.87 ns |      - |         - |
| **Stopwatch**      | **10**     | **317.17 ns** | **12.723 ns** | **0.697 ns** | **316.49 ns** | **317.88 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 309.30 ns | 19.656 ns | 1.077 ns | 308.46 ns | 310.51 ns |      - |         - |
