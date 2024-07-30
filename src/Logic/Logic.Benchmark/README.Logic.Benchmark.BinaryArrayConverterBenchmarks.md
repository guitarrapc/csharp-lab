```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.41 ns** |  **4.115 ns** | **0.226 ns** |  **18.17 ns** |  **18.61 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.80 ns |  2.126 ns | 0.117 ns |  66.66 ns |  66.87 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.32 ns |  3.042 ns | 0.167 ns |  20.13 ns |  20.42 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.01 ns |  2.249 ns | 0.123 ns |  10.89 ns |  11.14 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **56.68 ns** | **56.138 ns** | **3.077 ns** |  **53.76 ns** |  **59.89 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 198.65 ns |  4.482 ns | 0.246 ns | 198.37 ns | 198.83 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  66.97 ns | 14.388 ns | 0.789 ns |  66.08 ns |  67.58 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.88 ns |  4.520 ns | 0.248 ns |  35.61 ns |  36.10 ns | 0.0011 |      96 B |
