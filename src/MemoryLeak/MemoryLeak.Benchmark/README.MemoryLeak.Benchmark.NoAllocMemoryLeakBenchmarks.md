```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.23 ns** |   **3.071 ns** |  **0.168 ns** |  **34.12 ns** |  **34.43 ns** |         **-** |
| AllocateArrayPool | 1      |  97.71 ns |   3.155 ns |  0.173 ns |  97.60 ns |  97.91 ns |         - |
| **RentReturn**        | **10**     | **530.05 ns** | **192.245 ns** | **10.538 ns** | **522.87 ns** | **542.14 ns** |         **-** |
| AllocateArrayPool | 10     | 703.20 ns |  38.907 ns |  2.133 ns | 700.77 ns | 704.78 ns |         - |
