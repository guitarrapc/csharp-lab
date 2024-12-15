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
| **ToBinaryArrayInt**             | **1**      |  **18.23 ns** |  **3.202 ns** | **0.176 ns** |  **18.03 ns** |  **18.34 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  69.30 ns |  2.982 ns | 0.163 ns |  69.14 ns |  69.47 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.45 ns |  0.950 ns | 0.052 ns |  20.41 ns |  20.51 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.84 ns |  2.991 ns | 0.164 ns |  10.75 ns |  11.03 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **53.59 ns** | **10.238 ns** | **0.561 ns** |  **53.05 ns** |  **54.17 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 212.58 ns | 17.896 ns | 0.981 ns | 211.98 ns | 213.71 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  61.50 ns |  9.496 ns | 0.521 ns |  60.91 ns |  61.87 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  35.66 ns |  6.722 ns | 0.368 ns |  35.41 ns |  36.08 ns | 0.0011 |      96 B |
