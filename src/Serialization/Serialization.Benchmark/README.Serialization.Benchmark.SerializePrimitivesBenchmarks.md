```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data                 | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------- |--------------------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | Seria(...)tives [29] | 1,022.37 ns |  49.688 ns | 2.724 ns | 1,019.51 ns | 1,024.93 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)tives [29] |   966.38 ns |  60.865 ns | 3.336 ns |   963.51 ns |   970.04 ns | 0.0324 |     568 B |
| MemoryPack              | .NET 8.0 | Seria(...)tives [29] |    96.21 ns |   2.020 ns | 0.111 ns |    96.10 ns |    96.33 ns | 0.0072 |     120 B |
| SystemTextJson          | .NET 9.0 | Seria(...)tives [29] |   957.42 ns | 100.569 ns | 5.513 ns |   951.17 ns |   961.59 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)tives [29] |   890.08 ns |  16.442 ns | 0.901 ns |   889.26 ns |   891.05 ns | 0.0334 |     568 B |
| MemoryPack              | .NET 9.0 | Seria(...)tives [29] |    83.76 ns |   9.550 ns | 0.523 ns |    83.17 ns |    84.17 ns | 0.0072 |     120 B |
