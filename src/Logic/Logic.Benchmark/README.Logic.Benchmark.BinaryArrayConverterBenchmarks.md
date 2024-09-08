```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.98 ns** |   **1.912 ns** | **0.105 ns** |  **17.88 ns** |  **18.09 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  64.98 ns |   5.538 ns | 0.304 ns |  64.63 ns |  65.20 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.56 ns |   2.411 ns | 0.132 ns |  20.41 ns |  20.64 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.15 ns |   0.631 ns | 0.035 ns |  11.13 ns |  11.19 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.46 ns** |  **14.561 ns** | **0.798 ns** |  **53.54 ns** |  **55.01 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 205.00 ns | 177.403 ns | 9.724 ns | 199.28 ns | 216.23 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  60.97 ns |  35.810 ns | 1.963 ns |  58.76 ns |  62.50 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.16 ns |   2.977 ns | 0.163 ns |  35.01 ns |  35.33 ns | 0.0011 |      96 B |
