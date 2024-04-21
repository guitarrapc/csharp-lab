```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 633.23 ns |  76.698 ns | 4.204 ns | 628.39 ns | 636.01 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 689.97 ns | 115.319 ns | 6.321 ns | 682.69 ns | 694.06 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  56.99 ns |   3.699 ns | 0.203 ns |  56.76 ns |  57.11 ns | 0.0014 |     120 B |
