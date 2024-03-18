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
| SystemTextJson          | Seria(...)Class [29] | 685.27 ns | 107.70 ns | 5.904 ns | 681.43 ns | 692.07 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 754.08 ns |  58.40 ns | 3.201 ns | 752.13 ns | 757.78 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  65.70 ns |  20.00 ns | 1.096 ns |  64.51 ns |  66.66 ns | 0.0014 |     120 B |
