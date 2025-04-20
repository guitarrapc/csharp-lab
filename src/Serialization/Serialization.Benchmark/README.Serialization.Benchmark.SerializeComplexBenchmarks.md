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
| SystemTextJson          | .NET 8.0 | Seria(...)Class [29] | 629.84 ns |  17.130 ns | 0.939 ns | 628.87 ns | 630.74 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)Class [29] | 695.30 ns | 142.642 ns | 7.819 ns | 688.88 ns | 704.01 ns | 0.0277 |     464 B |
| MemoryPack              | .NET 8.0 | Seria(...)Class [29] |  56.77 ns |   5.931 ns | 0.325 ns |  56.48 ns |  57.12 ns | 0.0072 |     120 B |
| SystemTextJson          | .NET 9.0 | Seria(...)Class [29] | 601.94 ns |  31.206 ns | 1.711 ns | 599.98 ns | 603.13 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)Class [29] | 640.66 ns |  17.567 ns | 0.963 ns | 639.61 ns | 641.49 ns | 0.0277 |     464 B |
| MemoryPack              | .NET 9.0 | Seria(...)Class [29] |  44.44 ns |   3.230 ns | 0.177 ns |  44.24 ns |  44.58 ns | 0.0072 |     120 B |
