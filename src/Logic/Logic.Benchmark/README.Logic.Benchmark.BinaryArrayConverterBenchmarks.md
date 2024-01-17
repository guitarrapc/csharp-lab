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
| **ToBinaryArrayInt**             | **1**      |  **18.06 ns** |  **3.799 ns** | **0.208 ns** |  **17.86 ns** |  **18.27 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  65.30 ns |  3.327 ns | 0.182 ns |  65.10 ns |  65.46 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.53 ns |  0.157 ns | 0.009 ns |  20.52 ns |  20.54 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  11.04 ns |  0.955 ns | 0.052 ns |  11.00 ns |  11.10 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **10**     | **196.71 ns** | **19.278 ns** | **1.057 ns** | **195.81 ns** | **197.87 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString | 10     | 702.54 ns | 73.944 ns | 4.053 ns | 699.93 ns | 707.21 ns | 0.0114 |    1024 B |
| ToBinaryArrayIntMod          | 10     | 222.73 ns | 42.094 ns | 2.307 ns | 220.87 ns | 225.31 ns | 0.0038 |     320 B |
| ToBinaryArrayIntModNumber    | 10     | 150.34 ns | 22.699 ns | 1.244 ns | 148.94 ns | 151.31 ns | 0.0038 |     320 B |
