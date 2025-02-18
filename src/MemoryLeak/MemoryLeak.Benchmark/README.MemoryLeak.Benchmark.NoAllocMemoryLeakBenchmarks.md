```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method            | Job               | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------------------ |--------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **ShortRun-.NET 8.0** | **.NET 8.0** | **1**      |        **NA** |        **NA** |       **NA** |        **NA** |        **NA** |        **NA** |
| AllocateArrayPool | ShortRun-.NET 8.0 | .NET 8.0 | 1      |        NA |        NA |       NA |        NA |        NA |        NA |
| RentReturn        | ShortRun-.NET 9.0 | .NET 9.0 | 1      |  19.41 ns |  1.912 ns | 0.105 ns |  19.32 ns |  19.52 ns |         - |
| AllocateArrayPool | ShortRun-.NET 9.0 | .NET 9.0 | 1      |  83.37 ns |  1.236 ns | 0.068 ns |  83.29 ns |  83.42 ns |         - |
| **RentReturn**        | **ShortRun-.NET 8.0** | **.NET 8.0** | **10**     |        **NA** |        **NA** |       **NA** |        **NA** |        **NA** |        **NA** |
| AllocateArrayPool | ShortRun-.NET 8.0 | .NET 8.0 | 10     |        NA |        NA |       NA |        NA |        NA |        NA |
| RentReturn        | ShortRun-.NET 9.0 | .NET 9.0 | 10     | 411.73 ns | 17.937 ns | 0.983 ns | 410.60 ns | 412.35 ns |         - |
| AllocateArrayPool | ShortRun-.NET 9.0 | .NET 9.0 | 10     | 629.15 ns | 68.817 ns | 3.772 ns | 624.79 ns | 631.37 ns |         - |

Benchmarks with issues:
  NoAllocMemoryLeakBenchmarks.RentReturn: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=1]
  NoAllocMemoryLeakBenchmarks.AllocateArrayPool: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=1]
  NoAllocMemoryLeakBenchmarks.RentReturn: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=10]
  NoAllocMemoryLeakBenchmarks.AllocateArrayPool: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=10]
