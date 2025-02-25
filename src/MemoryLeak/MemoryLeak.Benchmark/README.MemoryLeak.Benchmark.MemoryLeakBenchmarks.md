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
| AllocateStringStatic | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   763.1 ns | 1,388.7 ns |  76.12 ns |   682.0 ns |   833.0 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateString       | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   739.7 ns |   373.4 ns |  20.47 ns |   724.4 ns |   762.9 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   706.0 ns |   899.3 ns |  49.29 ns |   650.9 ns |   745.9 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   733.2 ns |   902.9 ns |  49.49 ns |   677.7 ns |   772.8 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   708.6 ns |   855.6 ns |  46.90 ns |   656.1 ns |   746.5 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **ShortRun-.NET 8.0** | **.NET 8.0** | **3**      |         **NA** |         **NA** |        **NA** |         **NA** |         **NA** |     **NA** |     **NA** |        **NA** |
| AllocateString       | ShortRun-.NET 8.0 | .NET 8.0 | 3      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateLoH          | ShortRun-.NET 8.0 | .NET 8.0 | 3      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateArray        | ShortRun-.NET 8.0 | .NET 8.0 | 3      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateArrayPool    | ShortRun-.NET 8.0 | .NET 8.0 | 3      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateStringStatic | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,293.3 ns |   312.0 ns |  17.10 ns | 2,277.7 ns | 2,311.6 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateString       | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,157.3 ns | 2,719.6 ns | 149.07 ns | 1,986.6 ns | 2,262.1 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,019.2 ns | 1,966.9 ns | 107.81 ns | 1,934.5 ns | 2,140.5 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,036.9 ns |   414.2 ns |  22.70 ns | 2,023.3 ns | 2,063.1 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,138.7 ns | 2,358.2 ns | 129.26 ns | 1,990.2 ns | 2,226.3 ns | 0.1869 | 0.1831 |   3.07 KB |

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
