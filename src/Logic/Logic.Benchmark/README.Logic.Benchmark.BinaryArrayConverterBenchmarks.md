```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Allocated |
|----------------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **15.784 ns** |  **2.7243 ns** | **0.1493 ns** |  **15.658 ns** |  **15.949 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  62.264 ns |  7.3153 ns | 0.4010 ns |  61.875 ns |  62.676 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | 1      |  17.751 ns |  4.7180 ns | 0.2586 ns |  17.501 ns |  18.017 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |   9.471 ns |  1.4304 ns | 0.0784 ns |   9.393 ns |   9.550 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **49.834 ns** |  **0.9930 ns** | **0.0544 ns** |  **49.774 ns** |  **49.882 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 188.661 ns | 20.0420 ns | 1.0986 ns | 187.763 ns | 189.886 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | 3      |  56.980 ns |  4.5244 ns | 0.2480 ns |  56.798 ns |  57.263 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  31.831 ns |  3.9686 ns | 0.2175 ns |  31.596 ns |  32.026 ns | 0.0057 |      96 B |
