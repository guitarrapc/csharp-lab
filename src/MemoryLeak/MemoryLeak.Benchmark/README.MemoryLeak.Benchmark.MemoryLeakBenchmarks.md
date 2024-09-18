```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **787.4 ns** |   **729.3 ns** |  **39.97 ns** |   **741.2 ns** |   **810.9 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   759.7 ns |   947.3 ns |  51.92 ns |   701.8 ns |   802.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   726.4 ns | 1,034.5 ns |  56.70 ns |   670.1 ns |   783.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   794.5 ns |   507.4 ns |  27.81 ns |   774.6 ns |   826.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   725.5 ns | 1,096.3 ns |  60.09 ns |   686.7 ns |   794.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,242.3 ns** | **1,691.1 ns** |  **92.70 ns** | **2,161.2 ns** | **2,343.3 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,231.9 ns | 1,876.0 ns | 102.83 ns | 2,122.1 ns | 2,326.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,190.3 ns | 2,219.9 ns | 121.68 ns | 2,050.0 ns | 2,267.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,264.4 ns | 1,505.5 ns |  82.52 ns | 2,171.2 ns | 2,328.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,150.0 ns | 1,988.1 ns | 108.97 ns | 2,071.5 ns | 2,274.4 ns | 0.0343 | 0.0305 |   3.07 KB |
