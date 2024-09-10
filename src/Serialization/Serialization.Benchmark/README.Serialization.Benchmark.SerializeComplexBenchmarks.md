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
| SystemTextJson          | Seria(...)Class [29] | 658.22 ns | 46.283 ns | 2.537 ns | 656.70 ns | 661.15 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 687.40 ns |  7.369 ns | 0.404 ns | 687.05 ns | 687.84 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  65.08 ns |  9.771 ns | 0.536 ns |  64.47 ns |  65.50 ns | 0.0014 |     120 B |
