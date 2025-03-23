```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **.NET 8.0** | **1**      |  **61.95 ns** | **2.444 ns** | **0.134 ns** |  **61.87 ns** |  **62.10 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.47 ns | 1.046 ns | 0.057 ns |  57.41 ns |  57.52 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.06 ns | 0.129 ns | 0.007 ns |  58.06 ns |  58.07 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.39 ns | 0.238 ns | 0.013 ns |  57.38 ns |  57.40 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **121.90 ns** | **4.039 ns** | **0.221 ns** | **121.71 ns** | **122.15 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 115.86 ns | 1.655 ns | 0.091 ns | 115.80 ns | 115.96 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.64 ns | 0.765 ns | 0.042 ns | 117.60 ns | 117.69 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 116.35 ns | 1.280 ns | 0.070 ns | 116.28 ns | 116.42 ns |      - |         - |
