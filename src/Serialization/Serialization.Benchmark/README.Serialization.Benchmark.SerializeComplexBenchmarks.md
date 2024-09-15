```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 649.13 ns |  8.559 ns | 0.469 ns | 648.60 ns | 649.48 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 690.66 ns | 16.727 ns | 0.917 ns | 689.68 ns | 691.49 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  63.94 ns |  4.900 ns | 0.269 ns |  63.65 ns |  64.18 ns | 0.0014 |     120 B |
