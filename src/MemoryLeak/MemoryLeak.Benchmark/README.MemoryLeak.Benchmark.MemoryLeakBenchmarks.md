```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **753.0 ns** |   **337.2 ns** |  **18.48 ns** |   **731.7 ns** |   **763.9 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   721.3 ns |   357.1 ns |  19.57 ns |   698.8 ns |   734.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   705.7 ns |   604.6 ns |  33.14 ns |   683.1 ns |   743.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   726.2 ns |   268.2 ns |  14.70 ns |   717.0 ns |   743.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   727.7 ns |   483.3 ns |  26.49 ns |   697.4 ns |   746.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,232.6 ns** |   **634.7 ns** |  **34.79 ns** | **2,200.3 ns** | **2,269.4 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,151.7 ns | 1,122.9 ns |  61.55 ns | 2,086.3 ns | 2,208.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,117.8 ns | 1,883.5 ns | 103.24 ns | 2,008.9 ns | 2,214.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,155.8 ns | 1,608.6 ns |  88.17 ns | 2,061.2 ns | 2,235.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,163.3 ns | 1,190.5 ns |  65.26 ns | 2,095.6 ns | 2,225.8 ns | 0.0343 | 0.0305 |   3.07 KB |
