```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.44 ns** |  **5.422 ns** | **0.297 ns** |  **18.11 ns** |  **18.69 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.79 ns | 39.386 ns | 2.159 ns |  66.40 ns |  70.28 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.51 ns |  5.206 ns | 0.285 ns |  20.33 ns |  20.84 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.79 ns |  1.271 ns | 0.070 ns |  10.73 ns |  10.87 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **51.88 ns** |  **8.106 ns** | **0.444 ns** |  **51.48 ns** |  **52.36 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 203.71 ns |  2.671 ns | 0.146 ns | 203.54 ns | 203.81 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.44 ns | 12.818 ns | 0.703 ns |  62.98 ns |  64.25 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.91 ns |  1.960 ns | 0.107 ns |  36.85 ns |  37.04 ns | 0.0011 |      96 B |
