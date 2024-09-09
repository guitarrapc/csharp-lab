```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 665.39 ns | 38.697 ns | 2.121 ns | 662.94 ns | 666.69 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 693.32 ns |  2.597 ns | 0.142 ns | 693.23 ns | 693.48 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  62.90 ns |  4.316 ns | 0.237 ns |  62.73 ns |  63.17 ns | 0.0014 |     120 B |
