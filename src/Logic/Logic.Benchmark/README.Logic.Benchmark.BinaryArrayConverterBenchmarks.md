```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.43 ns** | **10.078 ns** | **0.552 ns** |  **16.79 ns** |  **17.77 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  64.70 ns |  4.821 ns | 0.264 ns |  64.39 ns |  64.85 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.33 ns |  2.817 ns | 0.154 ns |  20.16 ns |  20.46 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.76 ns |  0.700 ns | 0.038 ns |  10.72 ns |  10.80 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.82 ns** | **15.281 ns** | **0.838 ns** |  **54.87 ns** |  **56.47 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 201.01 ns | 20.184 ns | 1.106 ns | 199.75 ns | 201.85 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  62.67 ns | 33.362 ns | 1.829 ns |  61.36 ns |  64.76 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.61 ns |  1.936 ns | 0.106 ns |  35.51 ns |  35.72 ns | 0.0011 |      96 B |
