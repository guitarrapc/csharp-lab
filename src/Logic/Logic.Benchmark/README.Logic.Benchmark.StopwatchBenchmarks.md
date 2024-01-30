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
| **Stopwatch**      | **1**      |  **60.37 ns** |  **4.770 ns** | **0.261 ns** |  **60.21 ns** |  **60.67 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  55.88 ns |  0.412 ns | 0.023 ns |  55.86 ns |  55.91 ns |      - |         - |
| **Stopwatch**      | **10**     | **317.52 ns** | **16.830 ns** | **0.923 ns** | **316.67 ns** | **318.50 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 10     | 308.71 ns |  7.288 ns | 0.399 ns | 308.34 ns | 309.13 ns |      - |         - |
