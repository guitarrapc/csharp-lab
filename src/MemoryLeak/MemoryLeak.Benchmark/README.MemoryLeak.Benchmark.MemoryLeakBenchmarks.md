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
| **AllocateStringStatic** | **1**      |   **776.9 ns** |   **308.6 ns** | **16.91 ns** |   **765.5 ns** |   **796.3 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   719.8 ns |   253.1 ns | 13.88 ns |   707.2 ns |   734.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   695.4 ns |   495.8 ns | 27.18 ns |   678.3 ns |   726.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   719.9 ns |   525.0 ns | 28.78 ns |   686.7 ns |   738.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   731.0 ns |   337.7 ns | 18.51 ns |   713.8 ns |   750.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,202.0 ns** | **1,791.4 ns** | **98.19 ns** | **2,107.9 ns** | **2,303.8 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,121.9 ns | 1,632.9 ns | 89.51 ns | 2,047.8 ns | 2,221.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,079.0 ns | 1,521.1 ns | 83.38 ns | 1,984.6 ns | 2,142.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,167.2 ns | 1,551.8 ns | 85.06 ns | 2,070.1 ns | 2,228.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,158.3 ns | 1,352.7 ns | 74.15 ns | 2,077.7 ns | 2,223.5 ns | 0.0343 | 0.0305 |   3.07 KB |
