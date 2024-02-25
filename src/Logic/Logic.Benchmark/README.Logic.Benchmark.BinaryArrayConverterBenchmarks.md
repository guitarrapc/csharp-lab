```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.03 ns** |   **8.218 ns** | **0.450 ns** |  **17.53 ns** |  **18.40 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.58 ns |   9.796 ns | 0.537 ns |  67.26 ns |  68.20 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.46 ns |   3.539 ns | 0.194 ns |  20.34 ns |  20.69 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.32 ns |   3.837 ns | 0.210 ns |  11.15 ns |  11.56 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **190.71 ns** | **181.053 ns** | **9.924 ns** | **179.85 ns** | **199.31 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 708.56 ns |  59.587 ns | 3.266 ns | 704.97 ns | 711.35 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 224.60 ns |  27.372 ns | 1.500 ns | 222.87 ns | 225.53 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 151.71 ns |   6.554 ns | 0.359 ns | 151.50 ns | 152.13 ns | 0.0038 |     320 B |
