```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,009.38 ns | 11.883 ns | 0.651 ns | 1,008.63 ns | 1,009.85 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   935.42 ns | 85.536 ns | 4.689 ns |   932.00 ns |   940.76 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    96.86 ns |  1.837 ns | 0.101 ns |    96.78 ns |    96.97 ns | 0.0014 |     120 B |
