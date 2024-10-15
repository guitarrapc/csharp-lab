```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 632.88 ns |  3.723 ns | 0.204 ns | 632.65 ns | 633.01 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 690.49 ns | 32.333 ns | 1.772 ns | 689.25 ns | 692.52 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.78 ns |  1.852 ns | 0.101 ns |  57.67 ns |  57.87 ns | 0.0014 |     120 B |
