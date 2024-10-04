```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 672.76 ns | 137.388 ns |  7.531 ns | 666.76 ns | 681.21 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 710.54 ns | 199.997 ns | 10.963 ns | 703.02 ns | 723.12 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.43 ns |   2.113 ns |  0.116 ns |  58.35 ns |  58.56 ns | 0.0014 |     120 B |
