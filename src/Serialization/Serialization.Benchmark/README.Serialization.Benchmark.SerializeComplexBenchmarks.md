```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 677.02 ns |  35.188 ns | 1.929 ns | 675.86 ns | 679.25 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 700.91 ns | 105.933 ns | 5.807 ns | 696.79 ns | 707.55 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.81 ns |   2.643 ns | 0.145 ns |  58.69 ns |  58.97 ns | 0.0014 |     120 B |
