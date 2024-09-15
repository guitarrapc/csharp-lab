```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **763.7 ns** |   **428.9 ns** |  **23.51 ns** |   **749.9 ns** |   **790.9 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   725.9 ns |   347.3 ns |  19.04 ns |   704.3 ns |   740.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   723.6 ns |   303.8 ns |  16.65 ns |   711.6 ns |   742.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   756.5 ns |   379.7 ns |  20.81 ns |   733.2 ns |   773.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   716.9 ns |   364.0 ns |  19.95 ns |   701.8 ns |   739.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,257.3 ns** |   **409.3 ns** |  **22.44 ns** | **2,235.5 ns** | **2,280.3 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,169.8 ns | 1,273.3 ns |  69.79 ns | 2,092.1 ns | 2,227.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,124.5 ns | 1,923.1 ns | 105.41 ns | 2,007.7 ns | 2,212.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,209.8 ns | 1,225.0 ns |  67.15 ns | 2,135.9 ns | 2,267.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,160.0 ns |   959.7 ns |  52.60 ns | 2,113.2 ns | 2,216.9 ns | 0.0343 | 0.0305 |   3.07 KB |
