```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.98 ns** |  **4.153 ns** | **0.228 ns** |  **17.75 ns** |  **18.21 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.61 ns | 24.456 ns | 1.341 ns |  64.47 ns |  67.09 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.97 ns |  1.083 ns | 0.059 ns |  21.90 ns |  22.01 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.93 ns |  0.259 ns | 0.014 ns |  10.92 ns |  10.94 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **53.45 ns** | **20.115 ns** | **1.103 ns** |  **52.33 ns** |  **54.54 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 209.75 ns | 12.373 ns | 0.678 ns | 209.21 ns | 210.51 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.56 ns | 46.999 ns | 2.576 ns |  62.57 ns |  67.47 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.65 ns |  6.307 ns | 0.346 ns |  35.26 ns |  35.91 ns | 0.0011 |      96 B |
