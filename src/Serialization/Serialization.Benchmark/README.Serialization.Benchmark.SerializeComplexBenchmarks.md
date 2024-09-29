```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 642.53 ns | 13.42 ns | 0.736 ns | 642.03 ns | 643.37 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 707.45 ns | 10.69 ns | 0.586 ns | 706.99 ns | 708.11 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  59.17 ns | 16.56 ns | 0.908 ns |  58.64 ns |  60.22 ns | 0.0014 |     120 B |
