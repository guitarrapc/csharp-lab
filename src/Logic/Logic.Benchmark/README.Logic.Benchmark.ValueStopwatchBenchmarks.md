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
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.94 ns** | **2.018 ns** | **0.111 ns** |  **62.85 ns** |  **63.07 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  57.43 ns | 0.883 ns | 0.048 ns |  57.40 ns |  57.49 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.09 ns | 0.902 ns | 0.049 ns |  58.06 ns |  58.15 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  57.41 ns | 0.719 ns | 0.039 ns |  57.38 ns |  57.46 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **122.41 ns** | **2.609 ns** | **0.143 ns** | **122.30 ns** | **122.57 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 115.84 ns | 0.761 ns | 0.042 ns | 115.80 ns | 115.87 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.60 ns | 0.683 ns | 0.037 ns | 117.56 ns | 117.63 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 115.81 ns | 0.390 ns | 0.021 ns | 115.79 ns | 115.83 ns |      - |         - |
