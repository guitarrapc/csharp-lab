```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method               | Job               | Runtime  | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------------------ |--------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **ShortRun-.NET 8.0** | **.NET 8.0** | **1**      |         **NA** |         **NA** |        **NA** |         **NA** |         **NA** |     **NA** |     **NA** |        **NA** |
| AllocateString       | ShortRun-.NET 8.0 | .NET 8.0 | 1      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateLoH          | ShortRun-.NET 8.0 | .NET 8.0 | 1      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateArray        | ShortRun-.NET 8.0 | .NET 8.0 | 1      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateArrayPool    | ShortRun-.NET 8.0 | .NET 8.0 | 1      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateStringStatic | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   802.9 ns |   575.1 ns |  31.52 ns |   775.3 ns |   837.3 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateString       | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   753.8 ns |   428.5 ns |  23.49 ns |   730.9 ns |   777.9 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   714.5 ns | 1,019.1 ns |  55.86 ns |   651.2 ns |   757.0 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   750.0 ns |   260.5 ns |  14.28 ns |   739.7 ns |   766.3 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   726.6 ns | 1,059.9 ns |  58.10 ns |   662.8 ns |   776.5 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **ShortRun-.NET 8.0** | **.NET 8.0** | **3**      |         **NA** |         **NA** |        **NA** |         **NA** |         **NA** |     **NA** |     **NA** |        **NA** |
| AllocateString       | ShortRun-.NET 8.0 | .NET 8.0 | 3      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateLoH          | ShortRun-.NET 8.0 | .NET 8.0 | 3      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateArray        | ShortRun-.NET 8.0 | .NET 8.0 | 3      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateArrayPool    | ShortRun-.NET 8.0 | .NET 8.0 | 3      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateStringStatic | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,295.1 ns |   172.7 ns |   9.47 ns | 2,284.4 ns | 2,302.5 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateString       | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,043.4 ns |   622.3 ns |  34.11 ns | 2,023.5 ns | 2,082.8 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,190.5 ns |   541.1 ns |  29.66 ns | 2,171.7 ns | 2,224.7 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,122.3 ns | 1,873.7 ns | 102.71 ns | 2,049.3 ns | 2,239.7 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,124.2 ns | 2,181.5 ns | 119.58 ns | 1,988.1 ns | 2,212.5 ns | 0.1869 | 0.1831 |   3.07 KB |

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
