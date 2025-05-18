```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------- |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | Seria(...)tives [29] | 1,022.37 ns |  29.17 ns | 1.599 ns | 1,021.37 ns | 1,024.22 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)tives [29] |   938.06 ns |  47.85 ns | 2.623 ns |   936.15 ns |   941.05 ns | 0.0324 |     568 B |
| MemoryPack              | .NET 8.0 | Seria(...)tives [29] |    89.79 ns |  11.04 ns | 0.605 ns |    89.35 ns |    90.48 ns | 0.0072 |     120 B |
| SystemTextJson          | .NET 9.0 | Seria(...)tives [29] |   996.21 ns | 102.69 ns | 5.629 ns |   991.92 ns | 1,002.59 ns | 0.0267 |     464 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)tives [29] |   860.69 ns |  45.23 ns | 2.479 ns |   859.25 ns |   863.55 ns | 0.0334 |     568 B |
| MemoryPack              | .NET 9.0 | Seria(...)tives [29] |    77.58 ns |  24.40 ns | 1.337 ns |    76.13 ns |    78.76 ns | 0.0072 |     120 B |
