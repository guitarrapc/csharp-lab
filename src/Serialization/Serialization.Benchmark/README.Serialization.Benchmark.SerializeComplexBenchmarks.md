```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data                 | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |--------------------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | Seria(...)Class [29] | 658.51 ns |  93.004 ns | 5.098 ns | 654.61 ns | 664.28 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)Class [29] | 715.07 ns | 157.215 ns | 8.618 ns | 709.67 ns | 725.01 ns | 0.0277 |     464 B |
| MemoryPack              | .NET 8.0 | Seria(...)Class [29] |  56.79 ns |   8.935 ns | 0.490 ns |  56.38 ns |  57.33 ns | 0.0072 |     120 B |
| SystemTextJson          | .NET 9.0 | Seria(...)Class [29] | 605.09 ns |  42.792 ns | 2.346 ns | 603.22 ns | 607.72 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)Class [29] | 665.50 ns |  36.171 ns | 1.983 ns | 663.23 ns | 666.89 ns | 0.0277 |     464 B |
| MemoryPack              | .NET 9.0 | Seria(...)Class [29] |  45.41 ns |   3.575 ns | 0.196 ns |  45.20 ns |  45.59 ns | 0.0072 |     120 B |
