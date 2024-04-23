```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **19.16 ns** |  **4.235 ns** | **0.232 ns** |  **18.95 ns** |  **19.41 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  68.26 ns | 10.770 ns | 0.590 ns |  67.87 ns |  68.94 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.16 ns |  3.469 ns | 0.190 ns |  21.02 ns |  21.38 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.12 ns |  0.870 ns | 0.048 ns |  11.07 ns |  11.16 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.92 ns** | **16.571 ns** | **0.908 ns** |  **54.99 ns** |  **56.80 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 208.95 ns | 72.689 ns | 3.984 ns | 204.35 ns | 211.39 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  67.11 ns | 53.607 ns | 2.938 ns |  65.22 ns |  70.49 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.54 ns |  6.269 ns | 0.344 ns |  37.17 ns |  37.85 ns | 0.0011 |      96 B |
