```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | Seria(...)Class [29] | 626.38 ns | 30.612 ns | 1.678 ns | 625.02 ns | 628.26 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)Class [29] | 988.11 ns | 20.814 ns | 1.141 ns | 987.23 ns | 989.40 ns | 0.0277 |     464 B |
| MemoryPack              | .NET 8.0 | Seria(...)Class [29] |  57.84 ns | 15.838 ns | 0.868 ns |  57.01 ns |  58.74 ns | 0.0072 |     120 B |
| SystemTextJson          | .NET 9.0 | Seria(...)Class [29] | 596.85 ns | 67.078 ns | 3.677 ns | 592.66 ns | 599.55 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)Class [29] | 622.15 ns | 15.512 ns | 0.850 ns | 621.18 ns | 622.77 ns | 0.0277 |     464 B |
| MemoryPack              | .NET 9.0 | Seria(...)Class [29] |  42.74 ns |  5.440 ns | 0.298 ns |  42.41 ns |  42.99 ns | 0.0072 |     120 B |
