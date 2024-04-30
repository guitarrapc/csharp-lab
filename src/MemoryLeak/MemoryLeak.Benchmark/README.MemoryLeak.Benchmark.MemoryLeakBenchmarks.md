```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **769.8 ns** |   **538.1 ns** |  **29.49 ns** |   **751.4 ns** |   **803.8 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   776.9 ns |   569.5 ns |  31.22 ns |   747.6 ns |   809.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   739.7 ns |   154.5 ns |   8.47 ns |   730.4 ns |   747.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   782.6 ns |   354.8 ns |  19.45 ns |   760.3 ns |   796.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   739.3 ns |   358.9 ns |  19.67 ns |   721.6 ns |   760.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,308.6 ns** |   **414.7 ns** |  **22.73 ns** | **2,287.6 ns** | **2,332.7 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,179.3 ns | 1,766.4 ns |  96.82 ns | 2,093.1 ns | 2,284.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,183.9 ns |   418.7 ns |  22.95 ns | 2,162.8 ns | 2,208.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,239.8 ns | 1,730.5 ns |  94.85 ns | 2,183.3 ns | 2,349.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,277.4 ns | 2,909.0 ns | 159.45 ns | 2,176.4 ns | 2,461.2 ns | 0.0343 | 0.0305 |   3.07 KB |
