```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data                 | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |--------------------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | Seria(...)Class [29] | 658.94 ns | 106.011 ns | 5.811 ns | 654.85 ns | 665.59 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)Class [29] | 690.94 ns |  46.794 ns | 2.565 ns | 688.73 ns | 693.75 ns | 0.0277 |     464 B |
| MemoryPack              | .NET 8.0 | Seria(...)Class [29] |  61.02 ns |  16.167 ns | 0.886 ns |  60.03 ns |  61.75 ns | 0.0072 |     120 B |
| SystemTextJson          | .NET 9.0 | Seria(...)Class [29] | 616.51 ns |  18.015 ns | 0.987 ns | 615.77 ns | 617.63 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)Class [29] | 670.41 ns |   6.589 ns | 0.361 ns | 670.10 ns | 670.81 ns | 0.0277 |     464 B |
| MemoryPack              | .NET 9.0 | Seria(...)Class [29] |  46.51 ns |  10.665 ns | 0.585 ns |  45.84 ns |  46.88 ns | 0.0072 |     120 B |
