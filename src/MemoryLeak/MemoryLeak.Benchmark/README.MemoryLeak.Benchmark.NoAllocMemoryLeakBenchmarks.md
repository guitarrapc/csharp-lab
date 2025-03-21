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
| RentReturn        | ShortRun-.NET 9.0 | .NET 9.0 | 1      |  19.31 ns |   0.289 ns | 0.016 ns |  19.29 ns |  19.32 ns |         - |
| AllocateArrayPool | ShortRun-.NET 9.0 | .NET 9.0 | 1      |  82.91 ns |   8.264 ns | 0.453 ns |  82.61 ns |  83.43 ns |         - |
| **RentReturn**        | **ShortRun-.NET 8.0** | **.NET 8.0** | **10**     |        **NA** |         **NA** |       **NA** |        **NA** |        **NA** |        **NA** |
| AllocateArrayPool | ShortRun-.NET 8.0 | .NET 8.0 | 10     |        NA |         NA |       NA |        NA |        NA |        NA |
| RentReturn        | ShortRun-.NET 9.0 | .NET 9.0 | 10     | 414.11 ns |   3.917 ns | 0.215 ns | 413.88 ns | 414.31 ns |         - |
| AllocateArrayPool | ShortRun-.NET 9.0 | .NET 9.0 | 10     | 577.38 ns | 147.788 ns | 8.101 ns | 572.26 ns | 586.72 ns |         - |

Benchmarks with issues:
  NoAllocMemoryLeakBenchmarks.RentReturn: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=1]
  NoAllocMemoryLeakBenchmarks.AllocateArrayPool: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=1]
  NoAllocMemoryLeakBenchmarks.RentReturn: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=10]
  NoAllocMemoryLeakBenchmarks.AllocateArrayPool: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=10]
