```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.14 ns** | **8.486 ns** | **0.465 ns** |  **61.69 ns** |  **62.62 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.41 ns | 0.042 ns | 0.002 ns |  57.41 ns |  57.41 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.65 ns | 4.050 ns | 0.222 ns |  58.52 ns |  58.91 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.40 ns | 0.096 ns | 0.005 ns |  57.39 ns |  57.40 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **121.97 ns** | **4.369 ns** | **0.239 ns** | **121.75 ns** | **122.22 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 115.85 ns | 0.798 ns | 0.044 ns | 115.81 ns | 115.90 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.60 ns | 2.014 ns | 0.110 ns | 117.47 ns | 117.67 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 115.78 ns | 0.186 ns | 0.010 ns | 115.77 ns | 115.79 ns |      - |         - |
