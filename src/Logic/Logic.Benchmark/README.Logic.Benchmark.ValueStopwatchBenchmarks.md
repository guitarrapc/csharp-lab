```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |--------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **.NET 8.0** | **1**      |  **62.44 ns** | **2.622 ns** | **0.144 ns** |  **62.35 ns** |  **62.61 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 1      |  58.37 ns | 0.995 ns | 0.055 ns |  58.33 ns |  58.43 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 1      |  58.05 ns | 0.345 ns | 0.019 ns |  58.03 ns |  58.07 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 1      |  58.00 ns | 0.165 ns | 0.009 ns |  57.99 ns |  58.01 ns |      - |         - |
| **Stopwatch**      | **.NET 8.0** | **3**      | **121.16 ns** | **2.021 ns** | **0.111 ns** | **121.06 ns** | **121.28 ns** | **0.0024** |      **40 B** |
| ValueStopwatch | .NET 8.0 | 3      | 115.82 ns | 0.442 ns | 0.024 ns | 115.79 ns | 115.83 ns |      - |         - |
| Stopwatch      | .NET 9.0 | 3      | 117.59 ns | 2.428 ns | 0.133 ns | 117.48 ns | 117.74 ns |      - |         - |
| ValueStopwatch | .NET 9.0 | 3      | 115.86 ns | 0.855 ns | 0.047 ns | 115.83 ns | 115.91 ns |      - |         - |
