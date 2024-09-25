```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error        | StdDev     | Min       | Max         | Allocated |
|------------------ |------- |----------:|-------------:|-----------:|----------:|------------:|----------:|
| **RentReturn**        | **1**      |  **34.14 ns** |     **3.266 ns** |   **0.179 ns** |  **34.01 ns** |    **34.34 ns** |         **-** |
| AllocateArrayPool | 1      |  98.07 ns |     2.958 ns |   0.162 ns |  97.97 ns |    98.26 ns |         - |
| **RentReturn**        | **10**     | **520.06 ns** |   **306.852 ns** |  **16.820 ns** | **510.29 ns** |   **539.48 ns** |         **-** |
| AllocateArrayPool | 10     | 826.25 ns | 3,384.954 ns | 185.541 ns | 718.93 ns | 1,040.50 ns |         - |
