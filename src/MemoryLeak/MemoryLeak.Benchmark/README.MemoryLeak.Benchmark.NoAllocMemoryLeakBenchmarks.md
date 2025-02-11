```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method            | Job               | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------------------ |--------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **ShortRun-.NET 8.0** | **.NET 8.0** | **1**      |        **NA** |        **NA** |       **NA** |        **NA** |        **NA** |        **NA** |
| AllocateArrayPool | ShortRun-.NET 8.0 | .NET 8.0 | 1      |        NA |        NA |       NA |        NA |        NA |        NA |
| RentReturn        | ShortRun-.NET 9.0 | .NET 9.0 | 1      |  19.99 ns |  1.251 ns | 0.069 ns |  19.91 ns |  20.05 ns |         - |
| AllocateArrayPool | ShortRun-.NET 9.0 | .NET 9.0 | 1      |  83.96 ns |  5.217 ns | 0.286 ns |  83.64 ns |  84.19 ns |         - |
| **RentReturn**        | **ShortRun-.NET 8.0** | **.NET 8.0** | **10**     |        **NA** |        **NA** |       **NA** |        **NA** |        **NA** |        **NA** |
| AllocateArrayPool | ShortRun-.NET 8.0 | .NET 8.0 | 10     |        NA |        NA |       NA |        NA |        NA |        NA |
| RentReturn        | ShortRun-.NET 9.0 | .NET 9.0 | 10     | 420.91 ns | 79.458 ns | 4.355 ns | 418.35 ns | 425.94 ns |         - |
| AllocateArrayPool | ShortRun-.NET 9.0 | .NET 9.0 | 10     | 595.80 ns |  7.579 ns | 0.415 ns | 595.32 ns | 596.08 ns |         - |

Benchmarks with issues:
  NoAllocMemoryLeakBenchmarks.RentReturn: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=1]
  NoAllocMemoryLeakBenchmarks.AllocateArrayPool: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=1]
  NoAllocMemoryLeakBenchmarks.RentReturn: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=10]
  NoAllocMemoryLeakBenchmarks.AllocateArrayPool: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=10]
