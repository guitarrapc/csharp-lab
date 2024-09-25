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
| **AllocateStringStatic** | **1**      |   **790.9 ns** |   **315.9 ns** |  **17.32 ns** |   **778.6 ns** |   **810.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   720.2 ns |   994.7 ns |  54.52 ns |   685.3 ns |   783.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   710.6 ns |   408.0 ns |  22.36 ns |   685.3 ns |   727.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   768.1 ns |   315.0 ns |  17.27 ns |   753.5 ns |   787.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   711.8 ns |   668.0 ns |  36.62 ns |   688.5 ns |   754.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,209.8 ns** | **1,839.6 ns** | **100.84 ns** | **2,142.5 ns** | **2,325.8 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,242.2 ns | 2,231.8 ns | 122.33 ns | 2,114.2 ns | 2,357.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,115.2 ns | 1,814.8 ns |  99.48 ns | 2,007.3 ns | 2,203.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,293.1 ns |   790.3 ns |  43.32 ns | 2,259.0 ns | 2,341.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,115.9 ns | 2,370.2 ns | 129.92 ns | 2,035.9 ns | 2,265.8 ns | 0.0343 | 0.0305 |   3.07 KB |
