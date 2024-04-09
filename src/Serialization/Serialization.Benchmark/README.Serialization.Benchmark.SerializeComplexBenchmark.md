```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 645.44 ns | 43.814 ns | 2.402 ns | 643.48 ns | 648.12 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 694.30 ns | 15.732 ns | 0.862 ns | 693.77 ns | 695.29 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.09 ns |  1.159 ns | 0.064 ns |  58.05 ns |  58.16 ns | 0.0014 |     120 B |
