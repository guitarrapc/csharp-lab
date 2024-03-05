```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **766.1 ns** |   **585.5 ns** |  **32.09 ns** |   **735.6 ns** |   **799.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   736.4 ns |   160.1 ns |   8.78 ns |   731.2 ns |   746.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   711.7 ns |   185.4 ns |  10.16 ns |   704.0 ns |   723.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   726.4 ns |   228.7 ns |  12.53 ns |   713.0 ns |   737.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   733.2 ns |   508.4 ns |  27.87 ns |   705.7 ns |   761.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,244.3 ns** | **1,570.3 ns** |  **86.07 ns** | **2,162.8 ns** | **2,334.3 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,168.1 ns | 1,979.9 ns | 108.53 ns | 2,044.5 ns | 2,247.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,075.8 ns | 1,736.7 ns |  95.20 ns | 2,010.7 ns | 2,185.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,224.3 ns | 1,693.7 ns |  92.84 ns | 2,117.8 ns | 2,288.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,157.5 ns | 1,169.6 ns |  64.11 ns | 2,090.4 ns | 2,218.2 ns | 0.0343 | 0.0305 |   3.07 KB |
