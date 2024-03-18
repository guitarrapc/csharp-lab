```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.60 ns** |   **1.791 ns** |  **0.098 ns** |  **34.49 ns** |  **34.67 ns** |         **-** |
| AllocateArrayPool | 1      |  97.79 ns |   4.939 ns |  0.271 ns |  97.50 ns |  98.04 ns |         - |
| **RentReturn**        | **10**     | **529.57 ns** | **218.466 ns** | **11.975 ns** | **522.62 ns** | **543.39 ns** |         **-** |
| AllocateArrayPool | 10     | 712.48 ns |  55.813 ns |  3.059 ns | 709.24 ns | 715.33 ns |         - |
