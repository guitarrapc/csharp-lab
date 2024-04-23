```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **776.6 ns** |   **291.86 ns** | **16.00 ns** |   **758.9 ns** |   **790.1 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   738.8 ns |   137.87 ns |  7.56 ns |   730.1 ns |   743.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   695.4 ns |   534.43 ns | 29.29 ns |   668.3 ns |   726.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   744.4 ns |   122.44 ns |  6.71 ns |   737.3 ns |   750.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   736.3 ns |    81.88 ns |  4.49 ns |   732.3 ns |   741.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,245.5 ns** | **1,317.83 ns** | **72.23 ns** | **2,162.9 ns** | **2,296.8 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,115.8 ns |   909.78 ns | 49.87 ns | 2,059.9 ns | 2,155.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,055.3 ns |   628.78 ns | 34.47 ns | 2,022.4 ns | 2,091.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,184.3 ns | 1,186.70 ns | 65.05 ns | 2,119.8 ns | 2,249.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,142.5 ns |   927.95 ns | 50.86 ns | 2,083.9 ns | 2,175.2 ns | 0.0343 | 0.0305 |   3.07 KB |
