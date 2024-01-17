```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **18.95 ns** |   **3.333 ns** | **0.183 ns** |  **18.74 ns** |  **19.06 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.08 ns |   1.785 ns | 0.098 ns |  64.98 ns |  65.18 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.54 ns |   7.987 ns | 0.438 ns |  20.25 ns |  21.04 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.99 ns |   3.542 ns | 0.194 ns |  10.85 ns |  11.21 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **197.73 ns** |  **66.622 ns** | **3.652 ns** | **193.69 ns** | **200.79 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 678.27 ns |   7.332 ns | 0.402 ns | 677.96 ns | 678.72 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 225.50 ns | 171.356 ns | 9.393 ns | 216.09 ns | 234.87 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 152.70 ns |  44.892 ns | 2.461 ns | 151.23 ns | 155.54 ns | 0.0038 |     320 B |
