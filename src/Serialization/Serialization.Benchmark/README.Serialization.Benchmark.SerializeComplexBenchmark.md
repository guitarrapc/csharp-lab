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
| SystemTextJson          | Seria(...)Class [29] | 628.42 ns | 15.028 ns | 0.824 ns | 627.49 ns | 629.07 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 694.65 ns | 30.609 ns | 1.678 ns | 693.53 ns | 696.58 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  59.50 ns |  5.619 ns | 0.308 ns |  59.23 ns |  59.84 ns | 0.0014 |     120 B |
