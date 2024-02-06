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
| **ToBinaryArrayInt**             | **1**      |  **18.25 ns** |  **7.479 ns** | **0.410 ns** |  **17.89 ns** |  **18.69 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  66.84 ns |  3.707 ns | 0.203 ns |  66.67 ns |  67.06 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.69 ns |  8.378 ns | 0.459 ns |  20.42 ns |  21.22 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.79 ns |  0.701 ns | 0.038 ns |  10.75 ns |  10.83 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **185.98 ns** |  **9.901 ns** | **0.543 ns** | **185.39 ns** | **186.45 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 692.38 ns | 18.010 ns | 0.987 ns | 691.25 ns | 693.04 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 231.94 ns | 30.191 ns | 1.655 ns | 230.92 ns | 233.85 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 154.44 ns | 59.342 ns | 3.253 ns | 150.76 ns | 156.93 ns | 0.0038 |     320 B |
