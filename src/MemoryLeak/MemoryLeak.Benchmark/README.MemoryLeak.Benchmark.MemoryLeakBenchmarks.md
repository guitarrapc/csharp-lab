```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **756.5 ns** |   **420.3 ns** | **23.04 ns** |   **737.0 ns** |   **781.9 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   707.0 ns |   185.4 ns | 10.16 ns |   700.2 ns |   718.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   695.6 ns |   556.9 ns | 30.52 ns |   672.0 ns |   730.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   735.8 ns |   239.5 ns | 13.13 ns |   721.0 ns |   746.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   721.1 ns |   127.0 ns |  6.96 ns |   716.0 ns |   729.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,197.1 ns** | **1,065.0 ns** | **58.38 ns** | **2,132.2 ns** | **2,245.3 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,133.3 ns | 1,290.5 ns | 70.74 ns | 2,077.4 ns | 2,212.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,064.8 ns | 1,758.1 ns | 96.37 ns | 1,996.1 ns | 2,175.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,189.7 ns | 1,147.4 ns | 62.89 ns | 2,126.5 ns | 2,252.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,163.7 ns | 1,058.9 ns | 58.04 ns | 2,098.7 ns | 2,210.3 ns | 0.0343 | 0.0305 |   3.07 KB |
