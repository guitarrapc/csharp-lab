```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.88 ns** |   **6.237 ns** | **0.342 ns** |  **17.63 ns** |  **18.26 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.35 ns |  17.898 ns | 0.981 ns |  65.76 ns |  67.49 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.50 ns |   7.666 ns | 0.420 ns |  20.19 ns |  20.98 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.89 ns |   2.584 ns | 0.142 ns |  10.80 ns |  11.05 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **59.73 ns** |  **25.393 ns** | **1.392 ns** |  **58.64 ns** |  **61.30 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 205.29 ns | 128.993 ns | 7.071 ns | 200.70 ns | 213.43 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  64.92 ns |  10.328 ns | 0.566 ns |  64.28 ns |  65.35 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.33 ns |   7.730 ns | 0.424 ns |  36.84 ns |  37.63 ns | 0.0011 |      96 B |
