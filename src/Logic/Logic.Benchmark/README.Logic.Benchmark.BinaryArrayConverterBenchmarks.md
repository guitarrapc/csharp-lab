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
| **ToBinaryArrayInt**             | **1**      |  **18.78 ns** | **17.418 ns** | **0.955 ns** |  **17.85 ns** |  **19.76 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  69.22 ns | 30.863 ns | 1.692 ns |  68.10 ns |  71.17 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  21.25 ns |  3.222 ns | 0.177 ns |  21.11 ns |  21.45 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.06 ns |  1.034 ns | 0.057 ns |  11.00 ns |  11.11 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.93 ns** | **23.254 ns** | **1.275 ns** |  **53.70 ns** |  **56.24 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 204.68 ns |  8.965 ns | 0.491 ns | 204.14 ns | 205.10 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  65.02 ns |  7.285 ns | 0.399 ns |  64.77 ns |  65.48 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.78 ns |  3.549 ns | 0.195 ns |  37.57 ns |  37.96 ns | 0.0011 |      96 B |
