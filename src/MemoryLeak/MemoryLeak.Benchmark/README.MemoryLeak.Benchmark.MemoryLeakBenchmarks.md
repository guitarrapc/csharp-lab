```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **758.4 ns** |   **229.7 ns** | **12.59 ns** |   **746.6 ns** |   **771.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   728.5 ns |   542.1 ns | 29.71 ns |   694.5 ns |   749.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   724.3 ns |   359.3 ns | 19.69 ns |   712.6 ns |   747.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   743.1 ns |   511.9 ns | 28.06 ns |   716.9 ns |   772.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   724.0 ns |   488.4 ns | 26.77 ns |   693.3 ns |   742.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,225.6 ns** | **1,418.3 ns** | **77.74 ns** | **2,174.4 ns** | **2,315.0 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,142.7 ns |   437.1 ns | 23.96 ns | 2,115.4 ns | 2,160.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,130.5 ns | 1,574.4 ns | 86.30 ns | 2,031.1 ns | 2,185.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,229.7 ns |   828.1 ns | 45.39 ns | 2,195.8 ns | 2,281.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,120.1 ns | 1,111.1 ns | 60.91 ns | 2,055.6 ns | 2,176.6 ns | 0.0343 | 0.0305 |   3.07 KB |
