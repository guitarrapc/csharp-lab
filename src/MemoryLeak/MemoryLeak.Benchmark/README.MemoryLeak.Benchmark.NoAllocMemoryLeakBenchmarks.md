```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **32.88 ns** |   **2.536 ns** |  **0.139 ns** |  **32.76 ns** |  **33.03 ns** |         **-** |
| AllocateArrayPool | 1      |  97.22 ns |   6.325 ns |  0.347 ns |  96.99 ns |  97.62 ns |         - |
| **RentReturn**        | **10**     | **518.75 ns** |   **4.969 ns** |  **0.272 ns** | **518.47 ns** | **519.02 ns** |         **-** |
| AllocateArrayPool | 10     | 707.92 ns | 204.245 ns | 11.195 ns | 701.33 ns | 720.85 ns |         - |
