```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **754.3 ns** |   **107.3 ns** |  **5.88 ns** |   **750.0 ns** |   **761.0 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   718.8 ns |   347.2 ns | 19.03 ns |   700.0 ns |   738.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   700.9 ns |   583.2 ns | 31.97 ns |   674.6 ns |   736.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   754.4 ns |   304.1 ns | 16.67 ns |   744.0 ns |   773.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   749.3 ns |   343.9 ns | 18.85 ns |   737.5 ns |   771.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,227.3 ns** | **1,300.4 ns** | **71.28 ns** | **2,150.1 ns** | **2,290.6 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,158.2 ns |   658.4 ns | 36.09 ns | 2,116.5 ns | 2,179.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,064.3 ns | 1,153.0 ns | 63.20 ns | 2,007.2 ns | 2,132.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,154.7 ns | 1,169.8 ns | 64.12 ns | 2,100.8 ns | 2,225.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,148.9 ns |   702.2 ns | 38.49 ns | 2,124.8 ns | 2,193.3 ns | 0.0343 | 0.0305 |   3.07 KB |
