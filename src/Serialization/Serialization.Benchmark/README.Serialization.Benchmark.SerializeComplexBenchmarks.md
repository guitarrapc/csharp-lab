```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|----------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 602.54 ns |  67.74 ns |  3.713 ns | 599.54 ns | 606.69 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 675.53 ns | 184.49 ns | 10.112 ns | 664.23 ns | 683.73 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.04 ns |  13.08 ns |  0.717 ns |  57.62 ns |  58.87 ns | 0.0014 |     120 B |
