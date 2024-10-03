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
| **AllocateStringStatic** | **1**      |   **798.1 ns** |   **846.5 ns** |  **46.40 ns** |   **753.6 ns** |   **846.2 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   772.1 ns |   826.9 ns |  45.33 ns |   719.9 ns |   801.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   753.4 ns |   147.7 ns |   8.10 ns |   748.2 ns |   762.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   731.0 ns |   668.3 ns |  36.63 ns |   690.5 ns |   762.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   746.9 ns |   154.0 ns |   8.44 ns |   737.2 ns |   752.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,356.1 ns** | **2,106.9 ns** | **115.49 ns** | **2,222.8 ns** | **2,426.3 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,210.2 ns | 2,426.9 ns | 133.02 ns | 2,110.4 ns | 2,361.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,078.1 ns | 2,079.2 ns | 113.97 ns | 2,000.7 ns | 2,208.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,203.5 ns | 2,416.0 ns | 132.43 ns | 2,101.0 ns | 2,353.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,114.8 ns | 1,479.9 ns |  81.12 ns | 2,049.2 ns | 2,205.5 ns | 0.0343 | 0.0305 |   3.07 KB |
