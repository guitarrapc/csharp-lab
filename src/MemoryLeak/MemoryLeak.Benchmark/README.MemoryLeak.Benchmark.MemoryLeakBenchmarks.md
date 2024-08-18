```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **724.0 ns** |   **764.2 ns** |  **41.89 ns** |   **685.7 ns** |   **768.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   719.9 ns |   176.1 ns |   9.65 ns |   712.2 ns |   730.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   693.9 ns |   246.9 ns |  13.53 ns |   683.7 ns |   709.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   714.8 ns |   868.0 ns |  47.58 ns |   685.3 ns |   769.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   721.9 ns |   177.4 ns |   9.73 ns |   710.7 ns |   728.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,172.1 ns** |   **958.6 ns** |  **52.55 ns** | **2,126.0 ns** | **2,229.3 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,155.7 ns | 2,353.5 ns | 129.00 ns | 2,058.2 ns | 2,302.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,095.5 ns | 2,200.3 ns | 120.61 ns | 1,958.3 ns | 2,185.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,161.5 ns | 1,009.2 ns |  55.32 ns | 2,121.4 ns | 2,224.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,098.2 ns | 1,071.7 ns |  58.74 ns | 2,034.2 ns | 2,149.6 ns | 0.0343 | 0.0305 |   3.07 KB |
