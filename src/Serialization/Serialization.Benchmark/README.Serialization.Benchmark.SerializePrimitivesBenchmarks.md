```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data                 | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------- |--------------------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | Seria(...)tives [29] | 1,010.71 ns | 113.727 ns | 6.234 ns | 1,004.31 ns | 1,016.76 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)tives [29] |   927.96 ns |  42.673 ns | 2.339 ns |   925.82 ns |   930.46 ns | 0.0334 |     568 B |
| MemoryPack              | .NET 8.0 | Seria(...)tives [29] |    90.57 ns |   6.134 ns | 0.336 ns |    90.20 ns |    90.85 ns | 0.0072 |     120 B |
| SystemTextJson          | .NET 9.0 | Seria(...)tives [29] |   969.62 ns |  33.335 ns | 1.827 ns |   968.05 ns |   971.62 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)tives [29] |   877.20 ns |  36.362 ns | 1.993 ns |   874.95 ns |   878.73 ns | 0.0334 |     568 B |
| MemoryPack              | .NET 9.0 | Seria(...)tives [29] |    77.52 ns |   1.469 ns | 0.081 ns |    77.44 ns |    77.60 ns | 0.0072 |     120 B |
