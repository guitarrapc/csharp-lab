```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 611.92 ns | 172.32 ns | 9.445 ns | 604.24 ns | 622.47 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 656.05 ns | 118.43 ns | 6.492 ns | 649.51 ns | 662.49 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.27 ns |  16.79 ns | 0.920 ns |  56.27 ns |  58.09 ns | 0.0014 |     120 B |
