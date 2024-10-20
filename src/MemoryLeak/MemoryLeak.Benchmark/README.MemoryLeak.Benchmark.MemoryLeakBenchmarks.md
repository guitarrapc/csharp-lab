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
| **AllocateStringStatic** | **1**      |   **756.8 ns** |   **526.5 ns** |  **28.86 ns** |   **740.0 ns** |   **790.1 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   720.1 ns |   199.4 ns |  10.93 ns |   707.6 ns |   727.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   715.3 ns |   369.2 ns |  20.24 ns |   693.0 ns |   732.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   746.8 ns |   375.9 ns |  20.61 ns |   725.8 ns |   767.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   770.0 ns |   339.0 ns |  18.58 ns |   758.4 ns |   791.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,247.8 ns** | **2,184.8 ns** | **119.76 ns** | **2,156.3 ns** | **2,383.3 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,149.6 ns |   643.9 ns |  35.29 ns | 2,111.2 ns | 2,180.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,124.6 ns |   834.9 ns |  45.77 ns | 2,072.1 ns | 2,156.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,161.1 ns | 1,408.7 ns |  77.22 ns | 2,074.1 ns | 2,221.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,120.9 ns | 1,273.7 ns |  69.81 ns | 2,065.9 ns | 2,199.5 ns | 0.0343 | 0.0305 |   3.07 KB |
