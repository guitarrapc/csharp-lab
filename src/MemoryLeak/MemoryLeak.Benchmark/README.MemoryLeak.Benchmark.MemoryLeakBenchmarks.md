```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method               | Job               | Runtime  | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------------------ |--------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **ShortRun-.NET 8.0** | **.NET 8.0** | **1**      |         **NA** |         **NA** |        **NA** |         **NA** |         **NA** |     **NA** |     **NA** |        **NA** |
| AllocateString       | ShortRun-.NET 8.0 | .NET 8.0 | 1      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateLoH          | ShortRun-.NET 8.0 | .NET 8.0 | 1      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateArray        | ShortRun-.NET 8.0 | .NET 8.0 | 1      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateArrayPool    | ShortRun-.NET 8.0 | .NET 8.0 | 1      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateStringStatic | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   804.0 ns |   429.0 ns |  23.52 ns |   786.8 ns |   830.8 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateString       | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   776.5 ns |   366.2 ns |  20.07 ns |   756.1 ns |   796.3 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   695.9 ns |   641.5 ns |  35.16 ns |   673.2 ns |   736.4 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   754.2 ns |   960.6 ns |  52.66 ns |   694.3 ns |   793.5 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   736.9 ns |   881.7 ns |  48.33 ns |   683.6 ns |   777.8 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **ShortRun-.NET 8.0** | **.NET 8.0** | **3**      |         **NA** |         **NA** |        **NA** |         **NA** |         **NA** |     **NA** |     **NA** |        **NA** |
| AllocateString       | ShortRun-.NET 8.0 | .NET 8.0 | 3      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateLoH          | ShortRun-.NET 8.0 | .NET 8.0 | 3      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateArray        | ShortRun-.NET 8.0 | .NET 8.0 | 3      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateArrayPool    | ShortRun-.NET 8.0 | .NET 8.0 | 3      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateStringStatic | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,260.6 ns | 2,149.0 ns | 117.79 ns | 2,124.8 ns | 2,334.6 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateString       | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,187.3 ns | 2,498.3 ns | 136.94 ns | 2,088.7 ns | 2,343.6 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,248.5 ns |   179.4 ns |   9.83 ns | 2,240.8 ns | 2,259.6 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,207.7 ns | 2,757.0 ns | 151.12 ns | 2,104.9 ns | 2,381.3 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,046.8 ns |   343.4 ns |  18.82 ns | 2,025.0 ns | 2,058.5 ns | 0.1869 | 0.1831 |   3.07 KB |

Benchmarks with issues:
  MemoryLeakBenchmarks.AllocateStringStatic: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=1]
  MemoryLeakBenchmarks.AllocateString: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=1]
  MemoryLeakBenchmarks.AllocateLoH: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=1]
  MemoryLeakBenchmarks.AllocateArray: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=1]
  MemoryLeakBenchmarks.AllocateArrayPool: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=1]
  MemoryLeakBenchmarks.AllocateStringStatic: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=3]
  MemoryLeakBenchmarks.AllocateString: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=3]
  MemoryLeakBenchmarks.AllocateLoH: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=3]
  MemoryLeakBenchmarks.AllocateArray: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=3]
  MemoryLeakBenchmarks.AllocateArrayPool: ShortRun-.NET 8.0(Runtime=.NET 8.0, IterationCount=3, LaunchCount=1, WarmupCount=3) [Number=3]
