```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
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
| AllocateStringStatic | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   741.5 ns | 1,328.2 ns |  72.81 ns |   694.3 ns |   825.3 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateString       | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   726.6 ns |   626.7 ns |  34.35 ns |   688.9 ns |   756.1 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   736.4 ns |   474.1 ns |  25.99 ns |   713.5 ns |   764.6 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   728.2 ns |   808.5 ns |  44.32 ns |   678.2 ns |   762.6 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   741.2 ns |   366.7 ns |  20.10 ns |   725.4 ns |   763.8 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **ShortRun-.NET 8.0** | **.NET 8.0** | **3**      |         **NA** |         **NA** |        **NA** |         **NA** |         **NA** |     **NA** |     **NA** |        **NA** |
| AllocateString       | ShortRun-.NET 8.0 | .NET 8.0 | 3      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateLoH          | ShortRun-.NET 8.0 | .NET 8.0 | 3      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateArray        | ShortRun-.NET 8.0 | .NET 8.0 | 3      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateArrayPool    | ShortRun-.NET 8.0 | .NET 8.0 | 3      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateStringStatic | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,154.3 ns | 2,569.4 ns | 140.84 ns | 2,038.7 ns | 2,311.2 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateString       | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,197.8 ns | 2,431.7 ns | 133.29 ns | 2,044.1 ns | 2,281.9 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,196.2 ns |   111.8 ns |   6.13 ns | 2,191.4 ns | 2,203.1 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,311.4 ns |   755.3 ns |  41.40 ns | 2,286.5 ns | 2,359.2 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,026.0 ns |   654.6 ns |  35.88 ns | 1,993.5 ns | 2,064.5 ns | 0.1869 | 0.1831 |   3.07 KB |

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
