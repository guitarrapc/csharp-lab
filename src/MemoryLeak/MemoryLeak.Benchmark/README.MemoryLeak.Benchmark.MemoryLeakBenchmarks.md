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
| **AllocateStringStatic** | **1**      |   **769.0 ns** |   **760.7 ns** |  **41.70 ns** |   **724.5 ns** |   **807.1 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   775.5 ns |   375.8 ns |  20.60 ns |   763.5 ns |   799.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   730.5 ns |   588.3 ns |  32.25 ns |   694.0 ns |   755.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   782.2 ns |   466.6 ns |  25.58 ns |   765.0 ns |   811.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   725.9 ns |   744.6 ns |  40.81 ns |   695.1 ns |   772.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,242.2 ns** | **3,315.1 ns** | **181.71 ns** | **2,135.3 ns** | **2,452.0 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,240.0 ns | 1,506.7 ns |  82.59 ns | 2,147.1 ns | 2,304.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,131.0 ns | 1,582.9 ns |  86.76 ns | 2,063.5 ns | 2,228.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,204.5 ns | 2,906.0 ns | 159.29 ns | 2,109.9 ns | 2,388.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,230.5 ns | 1,936.4 ns | 106.14 ns | 2,109.9 ns | 2,309.6 ns | 0.0343 | 0.0305 |   3.07 KB |
