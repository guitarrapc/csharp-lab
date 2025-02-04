```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **19.35 ns** |   **1.429 ns** | **0.078 ns** |  **19.29 ns** |  **19.44 ns** |         **-** |
| AllocateArrayPool | 1      |  82.30 ns |   3.231 ns | 0.177 ns |  82.13 ns |  82.48 ns |         - |
| **RentReturn**        | **10**     | **414.73 ns** |  **40.632 ns** | **2.227 ns** | **413.44 ns** | **417.30 ns** |         **-** |
| AllocateArrayPool | 10     | 582.65 ns | 153.766 ns | 8.428 ns | 573.12 ns | 589.13 ns |         - |
