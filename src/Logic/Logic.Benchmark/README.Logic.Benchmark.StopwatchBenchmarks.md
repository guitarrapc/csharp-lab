```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.16 ns** | **3.945 ns** | **0.216 ns** |  **60.93 ns** |  **61.36 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.89 ns | 0.293 ns | 0.016 ns |  55.87 ns |  55.90 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.91 ns** | **7.288 ns** | **0.399 ns** | **316.52 ns** | **317.32 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.44 ns | 1.216 ns | 0.067 ns | 308.39 ns | 308.51 ns |      - |         - |
