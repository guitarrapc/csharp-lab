```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **17.58 ns** |  **1.047 ns** | **0.057 ns** |  **17.52 ns** |  **17.64 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  71.58 ns | 27.953 ns | 1.532 ns |  69.86 ns |  72.80 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  19.96 ns |  4.921 ns | 0.270 ns |  19.66 ns |  20.17 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.76 ns |  0.753 ns | 0.041 ns |  10.73 ns |  10.80 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **54.36 ns** |  **5.978 ns** | **0.328 ns** |  **54.11 ns** |  **54.73 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 213.82 ns |  5.106 ns | 0.280 ns | 213.57 ns | 214.12 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  59.91 ns | 24.198 ns | 1.326 ns |  58.96 ns |  61.43 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.29 ns |  1.315 ns | 0.072 ns |  36.23 ns |  36.37 ns | 0.0011 |      96 B |
