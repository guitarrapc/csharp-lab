```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data                 | Mean      | Error     | StdDev   | Min       | Max      | Gen0   | Allocated |
|------------------------ |--------- |--------------------- |----------:|----------:|---------:|----------:|---------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | Seria(...)Class [26] | 422.21 ns | 32.721 ns | 1.794 ns | 420.55 ns | 424.1 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)Class [26] | 339.48 ns | 28.526 ns | 1.564 ns | 337.97 ns | 341.1 ns | 0.0219 |     368 B |
| MemoryPack              | .NET 8.0 | Seria(...)Class [26] |  99.79 ns |  4.044 ns | 0.222 ns |  99.56 ns | 100.0 ns | 0.0076 |     128 B |
| SystemTextJson          | .NET 9.0 | Seria(...)Class [26] | 384.93 ns | 36.185 ns | 1.983 ns | 382.64 ns | 386.1 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)Class [26] | 312.34 ns | 15.935 ns | 0.873 ns | 311.33 ns | 312.9 ns | 0.0219 |     368 B |
| MemoryPack              | .NET 9.0 | Seria(...)Class [26] | 109.51 ns | 21.775 ns | 1.194 ns | 108.33 ns | 110.7 ns | 0.0076 |     128 B |
