```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data      | json                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |---------- |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **.NET 8.0** | **Byte[103]** | **?**                    |  **90.19 ns** |  **3.868 ns** | **0.212 ns** |  **89.95 ns** |  **90.35 ns** | **0.0148** |     **248 B** |
| MemoryPack              | .NET 9.0 | Byte[103] | ?                    |  84.56 ns |  3.807 ns | 0.209 ns |  84.36 ns |  84.78 ns | 0.0148 |     248 B |
| **SystemTextJson**          | **.NET 8.0** | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **614.43 ns** | **12.939 ns** | **0.709 ns** | **613.89 ns** | **615.23 ns** | **0.0143** |     **248 B** |
| SystemTextJsonSourceGen | .NET 8.0 | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 580.96 ns | 18.924 ns | 1.037 ns | 579.77 ns | 581.58 ns | 0.0143 |     248 B |
| SystemTextJson          | .NET 9.0 | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 576.09 ns | 23.027 ns | 1.262 ns | 574.91 ns | 577.42 ns | 0.0143 |     248 B |
| SystemTextJsonSourceGen | .NET 9.0 | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 579.27 ns | 33.791 ns | 1.852 ns | 577.27 ns | 580.93 ns | 0.0143 |     248 B |
