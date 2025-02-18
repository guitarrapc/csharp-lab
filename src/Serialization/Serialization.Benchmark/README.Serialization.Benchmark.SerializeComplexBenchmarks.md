```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | Seria(...)Class [29] | 645.88 ns |  6.636 ns | 0.364 ns | 645.64 ns | 646.30 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)Class [29] | 700.61 ns | 40.369 ns | 2.213 ns | 698.60 ns | 702.98 ns | 0.0277 |     464 B |
| MemoryPack              | .NET 8.0 | Seria(...)Class [29] |  58.99 ns |  4.810 ns | 0.264 ns |  58.74 ns |  59.27 ns | 0.0072 |     120 B |
| SystemTextJson          | .NET 9.0 | Seria(...)Class [29] | 599.00 ns |  8.085 ns | 0.443 ns | 598.48 ns | 599.26 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)Class [29] | 632.21 ns | 17.782 ns | 0.975 ns | 631.15 ns | 633.08 ns | 0.0277 |     464 B |
| MemoryPack              | .NET 9.0 | Seria(...)Class [29] |  44.68 ns | 14.424 ns | 0.791 ns |  44.19 ns |  45.59 ns | 0.0072 |     120 B |
