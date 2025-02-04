```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|----------------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **ToBinaryArrayInt**             | **1**      |  **16.65 ns** |  **2.072 ns** | **0.114 ns** |  **16.54 ns** |  **16.76 ns** | **0.0019** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  69.72 ns |  8.232 ns | 0.451 ns |  69.34 ns |  70.22 ns | 0.0057 |      96 B |
| ToBinaryArrayIntMod          | 1      |  19.25 ns |  3.161 ns | 0.173 ns |  19.08 ns |  19.42 ns | 0.0019 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.78 ns |  0.591 ns | 0.032 ns |  10.75 ns |  10.82 ns | 0.0019 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.64 ns** | **26.656 ns** | **1.461 ns** |  **54.24 ns** |  **57.16 ns** | **0.0057** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 207.51 ns | 29.362 ns | 1.609 ns | 206.42 ns | 209.36 ns | 0.0176 |     296 B |
| ToBinaryArrayIntMod          | 3      |  60.26 ns |  3.450 ns | 0.189 ns |  60.11 ns |  60.47 ns | 0.0057 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  37.17 ns | 37.613 ns | 2.062 ns |  34.79 ns |  38.39 ns | 0.0057 |      96 B |
