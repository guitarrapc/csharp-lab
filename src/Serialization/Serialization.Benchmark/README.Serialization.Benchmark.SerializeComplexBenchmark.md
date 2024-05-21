```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 641.70 ns | 29.686 ns | 1.627 ns | 640.52 ns | 643.56 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 698.51 ns | 42.812 ns | 2.347 ns | 696.90 ns | 701.20 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  60.03 ns |  1.105 ns | 0.061 ns |  59.98 ns |  60.10 ns | 0.0014 |     120 B |
