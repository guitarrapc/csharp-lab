```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **772.7 ns** |   **294.4 ns** |  **16.14 ns** |   **761.7 ns** |   **791.2 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   744.7 ns |   905.3 ns |  49.62 ns |   696.6 ns |   795.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   704.0 ns |   818.0 ns |  44.84 ns |   677.7 ns |   755.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   765.6 ns |   329.1 ns |  18.04 ns |   747.4 ns |   783.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   744.1 ns |   200.0 ns |  10.96 ns |   733.2 ns |   755.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,248.2 ns** | **1,733.7 ns** |  **95.03 ns** | **2,139.7 ns** | **2,316.9 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,224.1 ns | 2,733.2 ns | 149.82 ns | 2,060.8 ns | 2,355.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,102.7 ns | 2,977.6 ns | 163.21 ns | 1,914.4 ns | 2,202.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,247.4 ns | 2,023.4 ns | 110.91 ns | 2,131.8 ns | 2,352.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,187.7 ns | 1,599.7 ns |  87.68 ns | 2,086.5 ns | 2,239.1 ns | 0.0343 | 0.0305 |   3.07 KB |
