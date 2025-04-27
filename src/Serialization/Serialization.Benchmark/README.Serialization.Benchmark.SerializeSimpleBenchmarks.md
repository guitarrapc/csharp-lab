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
| SystemTextJson          | .NET 8.0 | Seria(...)Class [26] | 430.28 ns | 24.414 ns | 1.338 ns | 428.92 ns | 431.59 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)Class [26] | 344.34 ns | 77.996 ns | 4.275 ns | 339.44 ns | 347.26 ns | 0.0219 |     368 B |
| MemoryPack              | .NET 8.0 | Seria(...)Class [26] | 106.79 ns | 12.799 ns | 0.702 ns | 106.02 ns | 107.40 ns | 0.0076 |     128 B |
| SystemTextJson          | .NET 9.0 | Seria(...)Class [26] | 399.60 ns |  8.981 ns | 0.492 ns | 399.26 ns | 400.17 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)Class [26] | 321.60 ns | 73.502 ns | 4.029 ns | 319.06 ns | 326.25 ns | 0.0219 |     368 B |
| MemoryPack              | .NET 9.0 | Seria(...)Class [26] |  87.07 ns | 15.251 ns | 0.836 ns |  86.40 ns |  88.01 ns | 0.0076 |     128 B |
