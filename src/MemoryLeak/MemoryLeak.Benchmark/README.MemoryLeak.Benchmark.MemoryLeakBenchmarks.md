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
| **AllocateStringStatic** | **1**      |   **754.5 ns** |   **183.7 ns** |  **10.07 ns** |   **744.5 ns** |   **764.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   725.2 ns |   412.4 ns |  22.60 ns |   699.1 ns |   738.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   708.0 ns |   173.0 ns |   9.48 ns |   697.2 ns |   715.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   733.8 ns |   199.6 ns |  10.94 ns |   726.1 ns |   746.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   727.1 ns |   523.9 ns |  28.71 ns |   693.9 ns |   744.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,233.8 ns** |   **973.3 ns** |  **53.35 ns** | **2,172.8 ns** | **2,271.6 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,156.5 ns | 1,741.0 ns |  95.43 ns | 2,054.2 ns | 2,243.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,107.9 ns | 1,869.8 ns | 102.49 ns | 2,030.3 ns | 2,224.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,245.0 ns |   214.7 ns |  11.77 ns | 2,234.9 ns | 2,257.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,133.1 ns | 1,374.2 ns |  75.33 ns | 2,054.2 ns | 2,204.3 ns | 0.0343 | 0.0305 |   3.07 KB |
