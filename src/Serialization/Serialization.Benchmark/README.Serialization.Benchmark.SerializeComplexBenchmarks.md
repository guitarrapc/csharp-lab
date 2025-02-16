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
| SystemTextJson          | .NET 8.0 | Seria(...)Class [29] | 649.97 ns | 60.993 ns | 3.343 ns | 647.19 ns | 653.68 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)Class [29] | 716.08 ns | 45.638 ns | 2.502 ns | 714.37 ns | 718.95 ns | 0.0277 |     464 B |
| MemoryPack              | .NET 8.0 | Seria(...)Class [29] |  67.54 ns | 23.166 ns | 1.270 ns |  66.75 ns |  69.01 ns | 0.0072 |     120 B |
| SystemTextJson          | .NET 9.0 | Seria(...)Class [29] | 619.21 ns | 79.309 ns | 4.347 ns | 616.37 ns | 624.22 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)Class [29] | 673.95 ns | 23.929 ns | 1.312 ns | 672.76 ns | 675.36 ns | 0.0277 |     464 B |
| MemoryPack              | .NET 9.0 | Seria(...)Class [29] |  46.69 ns |  6.196 ns | 0.340 ns |  46.34 ns |  47.01 ns | 0.0072 |     120 B |
