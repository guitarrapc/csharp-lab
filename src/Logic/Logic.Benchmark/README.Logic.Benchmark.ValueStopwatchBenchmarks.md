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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **61.25 ns** | **2.794 ns** | **0.153 ns** |  **61.13 ns** |  **61.42 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.48 ns | 0.967 ns | 0.053 ns |  57.43 ns |  57.54 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.05 ns | 0.160 ns | 0.009 ns |  58.05 ns |  58.06 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  58.01 ns | 0.057 ns | 0.003 ns |  58.01 ns |  58.02 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **120.73 ns** | **6.502 ns** | **0.356 ns** | **120.32 ns** | **120.97 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 115.85 ns | 0.243 ns | 0.013 ns | 115.83 ns | 115.86 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.73 ns | 3.146 ns | 0.172 ns | 117.53 ns | 117.86 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 116.43 ns | 3.111 ns | 0.171 ns | 116.30 ns | 116.62 ns |      - |         - |
