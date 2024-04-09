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
| **ToBinaryArrayInt**             | **1**      |  **17.12 ns** |  **4.824 ns** | **0.264 ns** |  **16.90 ns** |  **17.41 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  68.89 ns | 17.816 ns | 0.977 ns |  68.15 ns |  70.00 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.49 ns |  2.902 ns | 0.159 ns |  20.35 ns |  20.66 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.71 ns |  1.055 ns | 0.058 ns |  10.65 ns |  10.76 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **56.28 ns** |  **6.100 ns** | **0.334 ns** |  **55.91 ns** |  **56.55 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 206.61 ns | 40.357 ns | 2.212 ns | 204.12 ns | 208.35 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.08 ns | 25.401 ns | 1.392 ns |  61.52 ns |  64.20 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.80 ns |  2.123 ns | 0.116 ns |  35.67 ns |  35.88 ns | 0.0011 |      96 B |
