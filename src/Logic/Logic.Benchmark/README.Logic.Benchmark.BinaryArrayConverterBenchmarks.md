```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **16.98 ns** |  **3.845 ns** | **0.211 ns** |  **16.85 ns** |  **17.22 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.22 ns |  5.674 ns | 0.311 ns |  66.92 ns |  67.54 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.35 ns |  1.808 ns | 0.099 ns |  20.25 ns |  20.45 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.88 ns |  2.997 ns | 0.164 ns |  10.71 ns |  11.04 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.57 ns** | **38.055 ns** | **2.086 ns** |  **52.19 ns** |  **56.04 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.57 ns |  8.326 ns | 0.456 ns | 201.21 ns | 202.09 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.29 ns |  4.900 ns | 0.269 ns |  61.04 ns |  61.57 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.56 ns | 15.417 ns | 0.845 ns |  35.92 ns |  37.52 ns | 0.0011 |      96 B |
