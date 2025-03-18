```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | Seria(...)Class [26] | 422.12 ns | 43.141 ns | 2.365 ns | 419.53 ns | 424.16 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)Class [26] | 331.85 ns | 65.509 ns | 3.591 ns | 329.67 ns | 335.99 ns | 0.0219 |     368 B |
| MemoryPack              | .NET 8.0 | Seria(...)Class [26] |  99.25 ns |  6.931 ns | 0.380 ns |  98.85 ns |  99.60 ns | 0.0076 |     128 B |
| SystemTextJson          | .NET 9.0 | Seria(...)Class [26] | 376.26 ns | 17.934 ns | 0.983 ns | 375.33 ns | 377.28 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)Class [26] | 318.33 ns | 44.962 ns | 2.465 ns | 316.42 ns | 321.11 ns | 0.0219 |     368 B |
| MemoryPack              | .NET 9.0 | Seria(...)Class [26] |  83.09 ns |  6.622 ns | 0.363 ns |  82.85 ns |  83.51 ns | 0.0076 |     128 B |
