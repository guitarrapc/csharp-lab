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
| SystemTextJson          | .NET 8.0 | Seria(...)tives [29] | 1,008.61 ns | 108.176 ns | 5.930 ns | 1,002.38 ns | 1,014.18 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)tives [29] |   920.79 ns |  47.048 ns | 2.579 ns |   918.02 ns |   923.12 ns | 0.0334 |     568 B |
| MemoryPack              | .NET 8.0 | Seria(...)tives [29] |    90.27 ns |  21.228 ns | 1.164 ns |    89.51 ns |    91.61 ns | 0.0072 |     120 B |
| SystemTextJson          | .NET 9.0 | Seria(...)tives [29] |   958.05 ns | 105.524 ns | 5.784 ns |   952.38 ns |   963.95 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)tives [29] |   859.72 ns |  29.007 ns | 1.590 ns |   857.89 ns |   860.66 ns | 0.0334 |     568 B |
| MemoryPack              | .NET 9.0 | Seria(...)tives [29] |    77.45 ns |   9.625 ns | 0.528 ns |    77.02 ns |    78.04 ns | 0.0072 |     120 B |
