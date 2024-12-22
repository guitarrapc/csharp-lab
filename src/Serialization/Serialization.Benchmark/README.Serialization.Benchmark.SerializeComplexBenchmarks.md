```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 595.15 ns | 186.813 ns | 10.240 ns | 588.93 ns | 606.97 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 629.50 ns |  22.285 ns |  1.221 ns | 628.30 ns | 630.74 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  45.88 ns |   4.128 ns |  0.226 ns |  45.68 ns |  46.13 ns | 0.0014 |     120 B |
