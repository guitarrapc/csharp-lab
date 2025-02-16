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
| SystemTextJson          | .NET 8.0 | Seria(...)Class [26] | 424.45 ns | 56.593 ns | 3.102 ns | 422.03 ns | 427.95 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)Class [26] | 339.32 ns |  6.871 ns | 0.377 ns | 338.89 ns | 339.59 ns | 0.0219 |     368 B |
| MemoryPack              | .NET 8.0 | Seria(...)Class [26] | 109.04 ns |  0.738 ns | 0.040 ns | 109.00 ns | 109.09 ns | 0.0076 |     128 B |
| SystemTextJson          | .NET 9.0 | Seria(...)Class [26] | 387.37 ns | 84.125 ns | 4.611 ns | 384.16 ns | 392.65 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)Class [26] | 316.15 ns | 20.987 ns | 1.150 ns | 314.91 ns | 317.19 ns | 0.0219 |     368 B |
| MemoryPack              | .NET 9.0 | Seria(...)Class [26] |  84.70 ns | 11.545 ns | 0.633 ns |  84.26 ns |  85.42 ns | 0.0076 |     128 B |
