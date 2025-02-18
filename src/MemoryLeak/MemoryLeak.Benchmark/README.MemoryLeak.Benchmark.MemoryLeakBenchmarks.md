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
| AllocateStringStatic | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   749.6 ns |   767.1 ns |  42.05 ns |   702.2 ns |   782.4 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateString       | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   762.9 ns |   264.9 ns |  14.52 ns |   754.5 ns |   779.7 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   704.6 ns |   734.6 ns |  40.26 ns |   660.2 ns |   738.7 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   727.2 ns |   590.0 ns |  32.34 ns |   694.2 ns |   758.8 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | ShortRun-.NET 9.0 | .NET 9.0 | 1      |   709.1 ns |   810.5 ns |  44.43 ns |   659.7 ns |   745.8 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **ShortRun-.NET 8.0** | **.NET 8.0** | **3**      |         **NA** |         **NA** |        **NA** |         **NA** |         **NA** |     **NA** |     **NA** |        **NA** |
| AllocateString       | ShortRun-.NET 8.0 | .NET 8.0 | 3      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateLoH          | ShortRun-.NET 8.0 | .NET 8.0 | 3      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateArray        | ShortRun-.NET 8.0 | .NET 8.0 | 3      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateArrayPool    | ShortRun-.NET 8.0 | .NET 8.0 | 3      |         NA |         NA |        NA |         NA |         NA |     NA |     NA |        NA |
| AllocateStringStatic | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,255.8 ns |   279.3 ns |  15.31 ns | 2,239.5 ns | 2,269.8 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateString       | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,162.1 ns | 2,108.5 ns | 115.57 ns | 2,028.9 ns | 2,236.0 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,172.8 ns |   328.7 ns |  18.02 ns | 2,161.5 ns | 2,193.6 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,103.3 ns |   368.9 ns |  20.22 ns | 2,082.4 ns | 2,122.7 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | ShortRun-.NET 9.0 | .NET 9.0 | 3      | 2,148.2 ns | 2,438.5 ns | 133.66 ns | 1,994.3 ns | 2,235.8 ns | 0.1869 | 0.1831 |   3.07 KB |

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
