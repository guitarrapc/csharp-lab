```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **770.7 ns** |   **162.99 ns** |  **8.93 ns** |   **762.8 ns** |   **780.4 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   747.1 ns |   525.27 ns | 28.79 ns |   720.6 ns |   777.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   735.2 ns |    15.05 ns |  0.83 ns |   734.5 ns |   736.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   760.5 ns |   258.86 ns | 14.19 ns |   747.0 ns |   775.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   741.0 ns |   154.43 ns |  8.46 ns |   732.3 ns |   749.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,288.3 ns** | **1,814.62 ns** | **99.47 ns** | **2,186.0 ns** | **2,384.6 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,222.4 ns | 1,372.89 ns | 75.25 ns | 2,142.5 ns | 2,292.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,160.5 ns |   902.88 ns | 49.49 ns | 2,104.4 ns | 2,198.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,222.8 ns | 1,198.81 ns | 65.71 ns | 2,152.2 ns | 2,282.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,192.2 ns | 1,219.40 ns | 66.84 ns | 2,115.0 ns | 2,232.3 ns | 0.0343 | 0.0305 |   3.07 KB |
