```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 648.13 ns |  76.746 ns | 4.207 ns | 644.73 ns | 652.83 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 703.93 ns | 118.128 ns | 6.475 ns | 699.56 ns | 711.37 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  60.88 ns |   5.714 ns | 0.313 ns |  60.69 ns |  61.24 ns | 0.0014 |     120 B |
