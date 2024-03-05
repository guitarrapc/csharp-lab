```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **779.2 ns** |   **708.11 ns** |  **38.81 ns** |   **736.4 ns** |   **812.0 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   755.5 ns |   299.22 ns |  16.40 ns |   737.2 ns |   768.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   731.2 ns |    64.29 ns |   3.52 ns |   727.8 ns |   734.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   774.3 ns |    71.05 ns |   3.89 ns |   770.0 ns |   777.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   796.5 ns |   446.03 ns |  24.45 ns |   781.6 ns |   824.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,350.8 ns** | **2,355.86 ns** | **129.13 ns** | **2,273.9 ns** | **2,499.9 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,409.2 ns |   895.81 ns |  49.10 ns | 2,370.4 ns | 2,464.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,226.1 ns | 1,021.00 ns |  55.96 ns | 2,168.4 ns | 2,280.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,328.6 ns |   118.97 ns |   6.52 ns | 2,321.3 ns | 2,333.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,201.7 ns |   861.48 ns |  47.22 ns | 2,166.1 ns | 2,255.3 ns | 0.0343 | 0.0305 |   3.07 KB |
