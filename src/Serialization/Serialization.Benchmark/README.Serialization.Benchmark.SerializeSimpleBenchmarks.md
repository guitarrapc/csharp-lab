```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | .NET 8.0 | Seria(...)Class [26] | 431.68 ns | 62.927 ns | 3.449 ns | 428.70 ns | 435.46 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | .NET 8.0 | Seria(...)Class [26] | 330.89 ns | 32.500 ns | 1.781 ns | 329.44 ns | 332.88 ns | 0.0219 |     368 B |
| MemoryPack              | .NET 8.0 | Seria(...)Class [26] | 103.11 ns |  4.935 ns | 0.271 ns | 102.87 ns | 103.41 ns | 0.0076 |     128 B |
| SystemTextJson          | .NET 9.0 | Seria(...)Class [26] | 387.61 ns | 78.080 ns | 4.280 ns | 384.14 ns | 392.39 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | .NET 9.0 | Seria(...)Class [26] | 324.26 ns |  7.655 ns | 0.420 ns | 323.97 ns | 324.74 ns | 0.0219 |     368 B |
| MemoryPack              | .NET 9.0 | Seria(...)Class [26] |  84.20 ns | 11.804 ns | 0.647 ns |  83.49 ns |  84.76 ns | 0.0076 |     128 B |
