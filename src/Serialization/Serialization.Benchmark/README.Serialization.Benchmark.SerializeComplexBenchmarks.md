```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 625.18 ns |  1.169 ns | 0.064 ns | 625.11 ns | 625.24 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 689.95 ns | 21.076 ns | 1.155 ns | 688.73 ns | 691.03 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  61.00 ns |  1.598 ns | 0.088 ns |  60.92 ns |  61.09 ns | 0.0014 |     120 B |
