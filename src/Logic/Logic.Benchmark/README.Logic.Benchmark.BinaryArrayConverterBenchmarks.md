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
| **ToBinaryArrayInt**             | **1**      |  **18.84 ns** |   **1.753 ns** | **0.096 ns** |  **18.75 ns** |  **18.94 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  64.89 ns |   1.566 ns | 0.086 ns |  64.80 ns |  64.96 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.40 ns |   7.527 ns | 0.413 ns |  20.12 ns |  20.87 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.84 ns |   0.818 ns | 0.045 ns |  10.81 ns |  10.89 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **200.04 ns** |  **68.619 ns** | **3.761 ns** | **195.73 ns** | **202.64 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 693.47 ns |  68.384 ns | 3.748 ns | 690.52 ns | 697.69 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 232.35 ns | 159.475 ns | 8.741 ns | 222.62 ns | 239.53 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 151.20 ns |  51.261 ns | 2.810 ns | 148.06 ns | 153.48 ns | 0.0038 |     320 B |
