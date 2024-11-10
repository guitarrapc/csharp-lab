```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **735.3 ns** |   **596.91 ns** | **32.72 ns** |   **715.4 ns** |   **773.0 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   732.7 ns |    29.04 ns |  1.59 ns |   731.2 ns |   734.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   729.8 ns |    83.67 ns |  4.59 ns |   724.8 ns |   733.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   740.0 ns |   236.17 ns | 12.95 ns |   731.3 ns |   754.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   688.6 ns |   156.46 ns |  8.58 ns |   679.4 ns |   696.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,191.1 ns** | **1,155.71 ns** | **63.35 ns** | **2,120.5 ns** | **2,243.0 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,161.3 ns | 1,294.33 ns | 70.95 ns | 2,080.4 ns | 2,212.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,128.9 ns | 1,526.41 ns | 83.67 ns | 2,063.6 ns | 2,223.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,181.5 ns | 1,656.33 ns | 90.79 ns | 2,078.3 ns | 2,249.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,107.5 ns | 1,023.01 ns | 56.07 ns | 2,061.0 ns | 2,169.8 ns | 0.0343 | 0.0305 |   3.07 KB |
