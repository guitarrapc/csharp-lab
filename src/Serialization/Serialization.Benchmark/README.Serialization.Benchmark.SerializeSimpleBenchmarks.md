```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 438.67 ns | 88.982 ns | 4.877 ns | 434.11 ns | 443.81 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 324.26 ns | 20.212 ns | 1.108 ns | 323.00 ns | 325.07 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  97.34 ns |  4.782 ns | 0.262 ns |  97.13 ns |  97.63 ns | 0.0014 |     128 B |
