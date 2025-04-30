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
| SystemTextJson          | .NET 8.0 | Seria(...)Class [26] | 465.14 ns | 68.168 ns | 3.737 ns | 460.83 ns | 467.43 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)Class [26] | 337.74 ns |  5.191 ns | 0.285 ns | 337.44 ns | 338.01 ns | 0.0219 |     368 B |
| MemoryPack              | .NET 8.0 | Seria(...)Class [26] |  99.91 ns |  4.760 ns | 0.261 ns |  99.67 ns | 100.19 ns | 0.0076 |     128 B |
| SystemTextJson          | .NET 9.0 | Seria(...)Class [26] | 411.43 ns | 37.623 ns | 2.062 ns | 409.08 ns | 412.94 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)Class [26] | 316.62 ns | 33.269 ns | 1.824 ns | 315.09 ns | 318.64 ns | 0.0219 |     368 B |
| MemoryPack              | .NET 9.0 | Seria(...)Class [26] |  85.13 ns |  6.757 ns | 0.370 ns |  84.82 ns |  85.54 ns | 0.0076 |     128 B |
