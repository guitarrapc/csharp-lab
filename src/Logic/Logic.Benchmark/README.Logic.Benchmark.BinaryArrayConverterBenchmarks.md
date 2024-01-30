```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.24 ns** |  **1.802 ns** | **0.099 ns** |  **18.17 ns** |  **18.36 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  68.92 ns |  4.289 ns | 0.235 ns |  68.67 ns |  69.14 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.47 ns |  1.596 ns | 0.087 ns |  20.37 ns |  20.53 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.88 ns |  1.248 ns | 0.068 ns |  10.81 ns |  10.94 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **187.48 ns** |  **8.013 ns** | **0.439 ns** | **186.98 ns** | **187.83 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 710.09 ns | 48.266 ns | 2.646 ns | 707.04 ns | 711.67 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 235.93 ns | 12.834 ns | 0.703 ns | 235.12 ns | 236.36 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 152.93 ns | 36.051 ns | 1.976 ns | 151.41 ns | 155.17 ns | 0.0038 |     320 B |
