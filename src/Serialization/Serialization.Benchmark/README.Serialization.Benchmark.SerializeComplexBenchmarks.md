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
| SystemTextJson          | Seria(...)Class [29] | 645.23 ns | 25.289 ns | 1.386 ns | 644.22 ns | 646.81 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 692.83 ns | 92.914 ns | 5.093 ns | 689.88 ns | 698.71 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  62.24 ns |  2.769 ns | 0.152 ns |  62.09 ns |  62.40 ns | 0.0014 |     120 B |
