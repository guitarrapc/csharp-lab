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
| **Stopwatch**      | **1**      |  **60.68 ns** |  **2.528 ns** | **0.139 ns** |  **60.52 ns** |  **60.78 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.94 ns |  1.874 ns | 0.103 ns |  55.87 ns |  56.06 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.56 ns** |  **9.998 ns** | **0.548 ns** | **316.16 ns** | **317.18 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 309.03 ns | 17.652 ns | 0.968 ns | 308.41 ns | 310.14 ns |      - |         - |
