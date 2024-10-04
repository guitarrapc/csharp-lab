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
| **AllocateStringStatic** | **1**      |   **752.6 ns** |   **660.6 ns** |  **36.21 ns** |   **711.9 ns** |   **781.3 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   715.8 ns |   628.6 ns |  34.46 ns |   689.5 ns |   754.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   721.4 ns |   946.6 ns |  51.89 ns |   662.9 ns |   762.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   727.8 ns |   104.1 ns |   5.71 ns |   722.0 ns |   733.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   713.5 ns |   704.6 ns |  38.62 ns |   668.9 ns |   737.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,230.7 ns** | **2,156.9 ns** | **118.23 ns** | **2,094.8 ns** | **2,309.8 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,244.5 ns | 1,290.3 ns |  70.73 ns | 2,168.7 ns | 2,308.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,133.7 ns | 2,335.3 ns | 128.01 ns | 2,049.9 ns | 2,281.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,357.1 ns | 1,165.6 ns |  63.89 ns | 2,309.1 ns | 2,429.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,148.8 ns | 2,228.3 ns | 122.14 ns | 2,059.0 ns | 2,287.9 ns | 0.0343 | 0.0305 |   3.07 KB |
