```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **743.8 ns** |   **238.4 ns** | **13.06 ns** |   **728.7 ns** |   **751.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   732.1 ns |   416.5 ns | 22.83 ns |   705.9 ns |   747.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   725.9 ns |   483.3 ns | 26.49 ns |   705.9 ns |   755.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   736.6 ns |   359.3 ns | 19.69 ns |   716.3 ns |   755.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   731.2 ns |   312.5 ns | 17.13 ns |   716.3 ns |   749.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,226.5 ns** | **1,313.2 ns** | **71.98 ns** | **2,143.6 ns** | **2,273.2 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,225.4 ns | 1,282.9 ns | 70.32 ns | 2,156.6 ns | 2,297.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,173.6 ns |   585.0 ns | 32.06 ns | 2,137.2 ns | 2,197.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,224.4 ns | 1,303.2 ns | 71.43 ns | 2,156.0 ns | 2,298.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,147.8 ns | 1,326.8 ns | 72.72 ns | 2,088.9 ns | 2,229.1 ns | 0.0343 | 0.0305 |   3.07 KB |
