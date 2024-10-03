```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 656.85 ns | 105.273 ns | 5.770 ns | 651.72 ns | 663.10 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 711.28 ns |  34.517 ns | 1.892 ns | 709.83 ns | 713.42 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  59.17 ns |   1.431 ns | 0.078 ns |  59.09 ns |  59.24 ns | 0.0014 |     120 B |
