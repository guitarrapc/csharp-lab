```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.32 ns** |  **1.772 ns** | **0.097 ns** |  **34.22 ns** |  **34.41 ns** |         **-** |
| AllocateArrayPool | 1      |  98.28 ns |  2.435 ns | 0.133 ns |  98.14 ns |  98.40 ns |         - |
| **RentReturn**        | **10**     | **519.80 ns** | **30.155 ns** | **1.653 ns** | **518.02 ns** | **521.29 ns** |         **-** |
| AllocateArrayPool | 10     | 701.49 ns | 53.878 ns | 2.953 ns | 698.96 ns | 704.73 ns |         - |
