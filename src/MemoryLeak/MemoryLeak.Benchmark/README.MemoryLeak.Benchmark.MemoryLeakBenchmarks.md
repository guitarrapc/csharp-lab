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
| **AllocateStringStatic** | **1**      |   **795.5 ns** |   **919.3 ns** |  **50.39 ns** |   **738.6 ns** |   **834.4 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   761.0 ns |   830.6 ns |  45.53 ns |   727.4 ns |   812.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   755.3 ns |   941.7 ns |  51.62 ns |   703.0 ns |   806.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   795.5 ns |   709.5 ns |  38.89 ns |   762.8 ns |   838.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   766.8 ns |   915.8 ns |  50.20 ns |   713.4 ns |   813.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,375.9 ns** | **2,673.1 ns** | **146.52 ns** | **2,211.7 ns** | **2,493.4 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,286.9 ns | 3,283.0 ns | 179.95 ns | 2,081.2 ns | 2,415.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,186.2 ns | 1,913.1 ns | 104.86 ns | 2,068.5 ns | 2,269.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,300.4 ns | 1,302.6 ns |  71.40 ns | 2,218.4 ns | 2,348.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,291.2 ns | 1,906.9 ns | 104.52 ns | 2,180.8 ns | 2,388.6 ns | 0.0343 | 0.0305 |   3.07 KB |
