```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **60.36 ns** |   **3.949 ns** | **0.216 ns** |  **60.11 ns** |  **60.51 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.86 ns |   0.242 ns | 0.013 ns |  55.85 ns |  55.88 ns |      - |         - |
| **Stopwatch**      | **10**     | **319.74 ns** | **107.954 ns** | **5.917 ns** | **316.14 ns** | **326.57 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.37 ns |   0.508 ns | 0.028 ns | 308.35 ns | 308.40 ns |      - |         - |
