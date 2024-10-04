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
| **AllocateStringStatic** | **1**      |   **753.9 ns** |   **854.9 ns** |  **46.86 ns** |   **704.7 ns** |   **798.1 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   711.7 ns |   875.9 ns |  48.01 ns |   673.2 ns |   765.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   736.1 ns |   318.1 ns |  17.44 ns |   718.6 ns |   753.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   752.6 ns |   944.1 ns |  51.75 ns |   693.0 ns |   786.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   717.0 ns |   684.0 ns |  37.49 ns |   677.4 ns |   752.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,237.8 ns** | **2,285.5 ns** | **125.28 ns** | **2,093.2 ns** | **2,315.0 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,126.1 ns | 1,547.5 ns |  84.82 ns | 2,055.5 ns | 2,220.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,047.0 ns | 1,666.9 ns |  91.37 ns | 1,976.6 ns | 2,150.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,157.8 ns | 2,104.9 ns | 115.38 ns | 2,032.6 ns | 2,259.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,161.2 ns | 1,521.0 ns |  83.37 ns | 2,069.7 ns | 2,232.9 ns | 0.0343 | 0.0305 |   3.07 KB |
