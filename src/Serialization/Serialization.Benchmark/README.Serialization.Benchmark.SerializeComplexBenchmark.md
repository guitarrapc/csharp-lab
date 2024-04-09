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
| SystemTextJson          | Seria(...)Class [29] | 636.64 ns | 35.386 ns | 1.940 ns | 635.30 ns | 638.87 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 700.91 ns |  5.947 ns | 0.326 ns | 700.56 ns | 701.20 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.91 ns |  7.208 ns | 0.395 ns |  57.60 ns |  58.35 ns | 0.0014 |     120 B |
