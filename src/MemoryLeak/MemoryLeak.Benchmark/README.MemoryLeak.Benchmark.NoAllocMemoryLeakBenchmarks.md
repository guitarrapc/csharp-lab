```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.25 ns** |   **1.352 ns** |  **0.074 ns** |  **34.18 ns** |  **34.33 ns** |         **-** |
| AllocateArrayPool | 1      |  98.86 ns |   7.717 ns |  0.423 ns |  98.39 ns |  99.21 ns |         - |
| **RentReturn**        | **10**     | **524.29 ns** | **130.338 ns** |  **7.144 ns** | **520.14 ns** | **532.53 ns** |         **-** |
| AllocateArrayPool | 10     | 714.71 ns | 214.547 ns | 11.760 ns | 704.64 ns | 727.63 ns |         - |
