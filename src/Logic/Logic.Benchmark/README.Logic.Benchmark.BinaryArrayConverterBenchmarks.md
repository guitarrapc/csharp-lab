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
| **ToBinaryArrayInt**             | **1**      |  **18.31 ns** |  **3.194 ns** | **0.175 ns** |  **18.12 ns** |  **18.46 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  69.50 ns | 11.325 ns | 0.621 ns |  68.89 ns |  70.13 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.47 ns |  4.188 ns | 0.230 ns |  21.24 ns |  21.70 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.39 ns |  1.142 ns | 0.063 ns |  11.32 ns |  11.43 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **52.51 ns** |  **4.339 ns** | **0.238 ns** |  **52.29 ns** |  **52.76 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 211.99 ns | 40.875 ns | 2.241 ns | 209.40 ns | 213.38 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  66.84 ns |  7.154 ns | 0.392 ns |  66.51 ns |  67.27 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  39.62 ns | 14.492 ns | 0.794 ns |  39.09 ns |  40.53 ns | 0.0011 |      96 B |
