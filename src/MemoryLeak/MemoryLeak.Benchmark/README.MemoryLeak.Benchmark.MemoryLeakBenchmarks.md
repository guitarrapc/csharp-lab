```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **761.0 ns** |   **189.35 ns** | **10.38 ns** |   **750.0 ns** |   **770.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   719.0 ns |    98.05 ns |  5.37 ns |   712.9 ns |   723.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   736.8 ns |   188.70 ns | 10.34 ns |   727.5 ns |   747.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   734.0 ns |   450.46 ns | 24.69 ns |   710.5 ns |   759.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   731.9 ns |   450.02 ns | 24.67 ns |   706.4 ns |   755.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,252.9 ns** |   **735.40 ns** | **40.31 ns** | **2,228.4 ns** | **2,299.4 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,149.1 ns | 1,107.69 ns | 60.72 ns | 2,086.9 ns | 2,208.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,096.4 ns | 1,008.71 ns | 55.29 ns | 2,060.1 ns | 2,160.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,216.4 ns | 1,011.00 ns | 55.42 ns | 2,157.9 ns | 2,268.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,167.0 ns |   585.13 ns | 32.07 ns | 2,130.1 ns | 2,188.0 ns | 0.0343 | 0.0305 |   3.07 KB |
