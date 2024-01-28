```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **60.40 ns** |  **5.036 ns** | **0.276 ns** |  **60.08 ns** |  **60.56 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.87 ns |  0.062 ns | 0.003 ns |  55.87 ns |  55.87 ns |      - |         - |
| **Stopwatch**      | **10**     | **316.60 ns** |  **9.734 ns** | **0.534 ns** | **316.25 ns** | **317.21 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 309.22 ns | 24.984 ns | 1.369 ns | 308.35 ns | 310.80 ns |      - |         - |
