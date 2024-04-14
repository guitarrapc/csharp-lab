```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **755.7 ns** |   **404.6 ns** |  **22.18 ns** |   **731.9 ns** |   **775.8 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   734.9 ns |   425.7 ns |  23.33 ns |   708.0 ns |   750.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   715.7 ns |   246.7 ns |  13.52 ns |   700.1 ns |   724.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   726.9 ns |   309.3 ns |  16.96 ns |   710.3 ns |   744.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   728.2 ns |   167.3 ns |   9.17 ns |   719.0 ns |   737.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,251.8 ns** | **1,092.4 ns** |  **59.88 ns** | **2,190.7 ns** | **2,310.3 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,222.6 ns |   154.4 ns |   8.46 ns | 2,213.9 ns | 2,230.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,192.2 ns | 1,992.0 ns | 109.19 ns | 2,066.2 ns | 2,258.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,189.5 ns |   886.0 ns |  48.57 ns | 2,133.5 ns | 2,218.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,207.4 ns | 1,243.2 ns |  68.14 ns | 2,128.8 ns | 2,249.4 ns | 0.0343 | 0.0305 |   3.07 KB |
