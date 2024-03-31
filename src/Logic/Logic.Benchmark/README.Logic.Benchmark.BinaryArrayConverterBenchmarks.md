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
| **ToBinaryArrayInt**             | **1**      |  **17.49 ns** |  **1.362 ns** | **0.075 ns** |  **17.44 ns** |  **17.58 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString | 1      |  67.49 ns | 15.476 ns | 0.848 ns |  66.87 ns |  68.45 ns | 0.0011 |      96 B |
| ToBinaryArrayIntMod          | 1      |  20.61 ns |  7.719 ns | 0.423 ns |  20.33 ns |  21.10 ns | 0.0004 |      32 B |
| ToBinaryArrayIntModNumber    | 1      |  10.88 ns |  0.506 ns | 0.028 ns |  10.85 ns |  10.91 ns | 0.0004 |      32 B |
| **ToBinaryArrayInt**             | **3**      |  **55.14 ns** |  **3.189 ns** | **0.175 ns** |  **55.03 ns** |  **55.34 ns** | **0.0011** |      **96 B** |
| ToBinaryArrayConvertToString | 3      | 200.50 ns |  8.320 ns | 0.456 ns | 199.97 ns | 200.79 ns | 0.0033 |     296 B |
| ToBinaryArrayIntMod          | 3      |  63.28 ns | 12.789 ns | 0.701 ns |  62.57 ns |  63.97 ns | 0.0011 |      96 B |
| ToBinaryArrayIntModNumber    | 3      |  36.45 ns |  6.241 ns | 0.342 ns |  36.22 ns |  36.84 ns | 0.0011 |      96 B |
