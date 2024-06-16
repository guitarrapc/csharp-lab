```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.40 ns** |  **2.900 ns** | **0.159 ns** |  **18.22 ns** |  **18.52 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.44 ns |  1.338 ns | 0.073 ns |  66.36 ns |  66.50 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.52 ns |  1.014 ns | 0.056 ns |  20.45 ns |  20.55 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.78 ns |  0.709 ns | 0.039 ns |  10.74 ns |  10.81 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **56.91 ns** | **24.824 ns** | **1.361 ns** |  **55.65 ns** |  **58.35 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.40 ns | 12.447 ns | 0.682 ns | 201.00 ns | 202.19 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.62 ns | 10.258 ns | 0.562 ns |  63.11 ns |  64.22 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.73 ns |  2.981 ns | 0.163 ns |  35.63 ns |  35.91 ns | 0.0011 |      96 B |
