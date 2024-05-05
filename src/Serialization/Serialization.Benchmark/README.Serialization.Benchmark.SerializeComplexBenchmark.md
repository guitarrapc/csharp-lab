```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 632.87 ns |  3.641 ns | 0.200 ns | 632.65 ns | 633.04 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 701.86 ns | 47.171 ns | 2.586 ns | 700.30 ns | 704.85 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.83 ns |  4.274 ns | 0.234 ns |  57.68 ns |  58.10 ns | 0.0014 |     120 B |
