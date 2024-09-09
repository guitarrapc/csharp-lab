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
| SystemTextJson          | Seria(...)tives [29] | 982.15 ns | 22.422 ns | 1.229 ns | 981.04 ns | 983.47 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 917.51 ns | 18.121 ns | 0.993 ns | 916.84 ns | 918.65 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  92.96 ns |  1.951 ns | 0.107 ns |  92.87 ns |  93.08 ns | 0.0014 |     120 B |
