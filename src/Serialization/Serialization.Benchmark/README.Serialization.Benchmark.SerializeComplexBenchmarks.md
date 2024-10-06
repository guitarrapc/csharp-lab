```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 656.75 ns | 20.012 ns | 1.097 ns | 655.48 ns | 657.40 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 700.14 ns | 48.496 ns | 2.658 ns | 698.60 ns | 703.21 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.66 ns |  1.709 ns | 0.094 ns |  58.57 ns |  58.75 ns | 0.0014 |     120 B |
