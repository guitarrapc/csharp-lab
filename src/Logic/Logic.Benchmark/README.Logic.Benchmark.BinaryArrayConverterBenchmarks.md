```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.76 ns** |  **3.249 ns** | **0.178 ns** |  **18.55 ns** |  **18.87 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.55 ns |  4.389 ns | 0.241 ns |  67.36 ns |  67.82 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.36 ns |  0.605 ns | 0.033 ns |  20.33 ns |  20.39 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.95 ns |  0.985 ns | 0.054 ns |  10.89 ns |  11.00 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **191.78 ns** | **95.631 ns** | **5.242 ns** | **187.03 ns** | **197.40 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 724.76 ns | 44.673 ns | 2.449 ns | 722.15 ns | 727.00 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 231.15 ns | 79.713 ns | 4.369 ns | 227.20 ns | 235.84 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 144.21 ns | 34.175 ns | 1.873 ns | 142.75 ns | 146.32 ns | 0.0038 |     320 B |
