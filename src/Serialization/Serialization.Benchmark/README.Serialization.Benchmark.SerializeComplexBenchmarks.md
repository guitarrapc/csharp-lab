```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 615.99 ns | 17.353 ns | 0.951 ns | 615.09 ns | 616.98 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 670.96 ns | 12.102 ns | 0.663 ns | 670.25 ns | 671.57 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  45.95 ns |  1.923 ns | 0.105 ns |  45.89 ns |  46.07 ns | 0.0014 |     120 B |
