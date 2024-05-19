```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **771.1 ns** |   **449.3 ns** |  **24.63 ns** |   **746.0 ns** |   **795.3 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   731.4 ns |   355.8 ns |  19.50 ns |   710.1 ns |   748.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   706.8 ns |   205.6 ns |  11.27 ns |   694.0 ns |   715.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   749.7 ns |   194.5 ns |  10.66 ns |   738.2 ns |   759.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   738.1 ns |   444.9 ns |  24.39 ns |   714.9 ns |   763.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,216.7 ns** | **1,204.1 ns** |  **66.00 ns** | **2,141.3 ns** | **2,263.9 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,195.6 ns | 1,485.5 ns |  81.43 ns | 2,119.5 ns | 2,281.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,023.2 ns | 1,908.5 ns | 104.61 ns | 1,962.1 ns | 2,144.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,236.0 ns |   700.5 ns |  38.40 ns | 2,192.2 ns | 2,263.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,253.8 ns |   671.9 ns |  36.83 ns | 2,216.1 ns | 2,289.7 ns | 0.0343 | 0.0305 |   3.07 KB |
