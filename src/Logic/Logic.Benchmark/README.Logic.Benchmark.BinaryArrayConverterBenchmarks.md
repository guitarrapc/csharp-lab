```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.63 ns** |  **3.418 ns** | **0.187 ns** |  **18.46 ns** |  **18.83 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.69 ns |  6.546 ns | 0.359 ns |  66.44 ns |  67.10 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.62 ns |  2.368 ns | 0.130 ns |  20.50 ns |  20.76 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.05 ns |  4.512 ns | 0.247 ns |  10.85 ns |  11.32 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.81 ns** |  **3.952 ns** | **0.217 ns** |  **55.57 ns** |  **55.99 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 202.16 ns | 34.145 ns | 1.872 ns | 200.87 ns | 204.30 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.14 ns | 14.514 ns | 0.796 ns |  62.57 ns |  64.05 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.88 ns |  6.033 ns | 0.331 ns |  37.56 ns |  38.22 ns | 0.0011 |      96 B |
