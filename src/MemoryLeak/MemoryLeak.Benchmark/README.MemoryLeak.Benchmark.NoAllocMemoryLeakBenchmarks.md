```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method            | Job               | Runtime  | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------------------ |--------- |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **ShortRun-.NET 8.0** | **.NET 8.0** | **1**      |        **NA** |         **NA** |       **NA** |        **NA** |        **NA** |        **NA** |
| AllocateArrayPool | ShortRun-.NET 8.0 | .NET 8.0 | 1      |        NA |         NA |       NA |        NA |        NA |        NA |
| RentReturn        | ShortRun-.NET 9.0 | .NET 9.0 | 1      |  21.46 ns |   0.658 ns | 0.036 ns |  21.42 ns |  21.49 ns |         - |
| AllocateArrayPool | ShortRun-.NET 9.0 | .NET 9.0 | 1      |  82.52 ns |   3.559 ns | 0.195 ns |  82.30 ns |  82.67 ns |         - |
| **RentReturn**        | **ShortRun-.NET 8.0** | **.NET 8.0** | **10**     |        **NA** |         **NA** |       **NA** |        **NA** |        **NA** |        **NA** |
| AllocateArrayPool | ShortRun-.NET 8.0 | .NET 8.0 | 10     |        NA |         NA |       NA |        NA |        NA |        NA |
| RentReturn        | ShortRun-.NET 9.0 | .NET 9.0 | 10     | 414.29 ns |  36.278 ns | 1.989 ns | 412.64 ns | 416.50 ns |         - |
| AllocateArrayPool | ShortRun-.NET 9.0 | .NET 9.0 | 10     | 578.63 ns | 122.228 ns | 6.700 ns | 574.51 ns | 586.36 ns |         - |

Benchmarks with issues:
  NoAllocMemoryLeakBenchmarks.RentReturn: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=1]
  NoAllocMemoryLeakBenchmarks.AllocateArrayPool: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=1]
  NoAllocMemoryLeakBenchmarks.RentReturn: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=10]
  NoAllocMemoryLeakBenchmarks.AllocateArrayPool: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=10]
