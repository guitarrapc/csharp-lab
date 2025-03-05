```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method            | Job               | Runtime  | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------------------ |--------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **ShortRun-.NET 8.0** | **.NET 8.0** | **1**      |        **NA** |         **NA** |        **NA** |        **NA** |        **NA** |        **NA** |
| AllocateArrayPool | ShortRun-.NET 8.0 | .NET 8.0 | 1      |        NA |         NA |        NA |        NA |        NA |        NA |
| RentReturn        | ShortRun-.NET 9.0 | .NET 9.0 | 1      |  20.17 ns |   2.235 ns |  0.123 ns |  20.05 ns |  20.30 ns |         - |
| AllocateArrayPool | ShortRun-.NET 9.0 | .NET 9.0 | 1      |  84.22 ns |   2.333 ns |  0.128 ns |  84.09 ns |  84.34 ns |         - |
| **RentReturn**        | **ShortRun-.NET 8.0** | **.NET 8.0** | **10**     |        **NA** |         **NA** |        **NA** |        **NA** |        **NA** |        **NA** |
| AllocateArrayPool | ShortRun-.NET 8.0 | .NET 8.0 | 10     |        NA |         NA |        NA |        NA |        NA |        NA |
| RentReturn        | ShortRun-.NET 9.0 | .NET 9.0 | 10     | 853.45 ns | 327.851 ns | 17.971 ns | 841.91 ns | 874.16 ns |         - |
| AllocateArrayPool | ShortRun-.NET 9.0 | .NET 9.0 | 10     | 581.67 ns |  12.002 ns |  0.658 ns | 581.16 ns | 582.41 ns |         - |

Benchmarks with issues:
  NoAllocMemoryLeakBenchmarks.RentReturn: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=1]
  NoAllocMemoryLeakBenchmarks.AllocateArrayPool: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=1]
  NoAllocMemoryLeakBenchmarks.RentReturn: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=10]
  NoAllocMemoryLeakBenchmarks.AllocateArrayPool: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=10]
