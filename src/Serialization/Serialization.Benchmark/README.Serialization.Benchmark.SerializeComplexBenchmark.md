```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 638.96 ns | 73.072 ns | 4.005 ns | 636.33 ns | 643.57 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 693.31 ns |  9.166 ns | 0.502 ns | 692.77 ns | 693.76 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.34 ns |  2.536 ns | 0.139 ns |  58.22 ns |  58.49 ns | 0.0014 |     120 B |
