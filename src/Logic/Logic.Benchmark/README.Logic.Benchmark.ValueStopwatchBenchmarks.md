```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.08 ns** | **6.710 ns** | **0.368 ns** |  **61.77 ns** |  **62.48 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  58.38 ns | 0.974 ns | 0.053 ns |  58.34 ns |  58.44 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  59.00 ns | 0.335 ns | 0.018 ns |  58.98 ns |  59.02 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  58.04 ns | 0.804 ns | 0.044 ns |  58.02 ns |  58.09 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **121.67 ns** | **7.375 ns** | **0.404 ns** | **121.33 ns** | **122.12 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 116.14 ns | 1.114 ns | 0.061 ns | 116.10 ns | 116.21 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.83 ns | 4.116 ns | 0.226 ns | 117.67 ns | 118.09 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 115.88 ns | 0.946 ns | 0.052 ns | 115.83 ns | 115.93 ns |      - |         - |
