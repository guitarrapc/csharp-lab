```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **765.9 ns** |   **252.7 ns** | **13.85 ns** |   **754.4 ns** |   **781.3 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   735.1 ns |   288.6 ns | 15.82 ns |   720.9 ns |   752.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   709.7 ns |   498.1 ns | 27.30 ns |   680.2 ns |   734.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   748.4 ns |   135.7 ns |  7.44 ns |   741.0 ns |   755.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   718.3 ns |   276.8 ns | 15.17 ns |   703.1 ns |   733.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,335.7 ns** |   **290.8 ns** | **15.94 ns** | **2,317.2 ns** | **2,345.0 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,193.9 ns |   946.6 ns | 51.89 ns | 2,150.2 ns | 2,251.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,083.4 ns |   831.9 ns | 45.60 ns | 2,051.3 ns | 2,135.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,269.8 ns | 1,249.9 ns | 68.51 ns | 2,194.5 ns | 2,328.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,126.7 ns |   501.8 ns | 27.51 ns | 2,097.9 ns | 2,152.7 ns | 0.0343 | 0.0305 |   3.07 KB |
