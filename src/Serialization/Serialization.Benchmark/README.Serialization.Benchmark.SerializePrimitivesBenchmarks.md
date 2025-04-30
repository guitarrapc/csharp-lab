```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data                 | Mean        | Error     | StdDev   | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------- |--------------------- |------------:|----------:|---------:|----------:|------------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | Seria(...)tives [29] | 1,000.87 ns | 66.677 ns | 3.655 ns | 997.11 ns | 1,004.41 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)tives [29] |   922.54 ns | 19.413 ns | 1.064 ns | 921.68 ns |   923.73 ns | 0.0334 |     568 B |
| MemoryPack              | .NET 8.0 | Seria(...)tives [29] |    90.17 ns |  2.524 ns | 0.138 ns |  90.01 ns |    90.28 ns | 0.0072 |     120 B |
| SystemTextJson          | .NET 9.0 | Seria(...)tives [29] |   959.43 ns | 63.678 ns | 3.490 ns | 955.64 ns |   962.50 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)tives [29] |   850.40 ns | 66.509 ns | 3.646 ns | 846.55 ns |   853.80 ns | 0.0334 |     568 B |
| MemoryPack              | .NET 9.0 | Seria(...)tives [29] |    79.66 ns | 14.212 ns | 0.779 ns |  78.86 ns |    80.41 ns | 0.0072 |     120 B |
