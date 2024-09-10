```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **19.18 ns** |  **5.165 ns** | **0.283 ns** |  **18.95 ns** |  **19.50 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  69.51 ns | 51.177 ns | 2.805 ns |  67.87 ns |  72.75 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.93 ns |  3.250 ns | 0.178 ns |  21.73 ns |  22.09 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.38 ns |  1.230 ns | 0.067 ns |  11.33 ns |  11.45 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **58.05 ns** | **39.777 ns** | **2.180 ns** |  **55.76 ns** |  **60.11 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 203.83 ns | 18.116 ns | 0.993 ns | 203.14 ns | 204.97 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.39 ns | 24.362 ns | 1.335 ns |  62.48 ns |  64.92 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.98 ns |  7.494 ns | 0.411 ns |  37.51 ns |  38.23 ns | 0.0011 |      96 B |
