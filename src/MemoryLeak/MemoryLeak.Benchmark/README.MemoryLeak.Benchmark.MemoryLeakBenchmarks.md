```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **785.4 ns** |   **103.3 ns** |  **5.66 ns** |   **779.9 ns** |   **791.2 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   733.8 ns |   203.8 ns | 11.17 ns |   721.4 ns |   742.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   714.6 ns |   291.2 ns | 15.96 ns |   696.2 ns |   724.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   744.0 ns |   330.0 ns | 18.09 ns |   723.8 ns |   758.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   738.0 ns |   109.7 ns |  6.01 ns |   732.1 ns |   744.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,297.9 ns** |   **914.5 ns** | **50.12 ns** | **2,240.8 ns** | **2,334.7 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,238.0 ns |   523.4 ns | 28.69 ns | 2,206.4 ns | 2,262.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,134.4 ns | 1,523.2 ns | 83.49 ns | 2,048.3 ns | 2,215.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,186.8 ns |   275.9 ns | 15.12 ns | 2,175.5 ns | 2,204.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,191.2 ns |   591.5 ns | 32.42 ns | 2,163.9 ns | 2,227.0 ns | 0.0343 | 0.0305 |   3.07 KB |
