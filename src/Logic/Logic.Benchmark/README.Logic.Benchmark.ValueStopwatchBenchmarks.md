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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.05 ns** | **4.923 ns** | **0.270 ns** |  **61.89 ns** |  **62.36 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  58.35 ns | 0.518 ns | 0.028 ns |  58.33 ns |  58.38 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.69 ns | 0.560 ns | 0.031 ns |  58.66 ns |  58.72 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  58.06 ns | 0.966 ns | 0.053 ns |  58.02 ns |  58.12 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **121.84 ns** | **5.914 ns** | **0.324 ns** | **121.49 ns** | **122.13 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 116.31 ns | 7.718 ns | 0.423 ns | 116.04 ns | 116.80 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.40 ns | 1.517 ns | 0.083 ns | 117.31 ns | 117.47 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 115.79 ns | 0.545 ns | 0.030 ns | 115.77 ns | 115.83 ns |      - |         - |
