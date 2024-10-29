```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 636.49 ns | 6.255 ns | 0.343 ns | 636.23 ns | 636.88 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 687.42 ns | 7.375 ns | 0.404 ns | 687.18 ns | 687.89 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.38 ns | 2.401 ns | 0.132 ns |  57.24 ns |  57.49 ns | 0.0014 |     120 B |
