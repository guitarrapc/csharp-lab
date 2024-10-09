```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 640.49 ns |  56.339 ns | 3.088 ns | 636.98 ns | 642.80 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 716.52 ns | 100.273 ns | 5.496 ns | 712.84 ns | 722.84 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.54 ns |   3.421 ns | 0.187 ns |  58.39 ns |  58.75 ns | 0.0014 |     120 B |
