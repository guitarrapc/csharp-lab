```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **Byte[89]** | **?**                   |  **52.12 ns** | **2.076 ns** | **0.114 ns** |  **52.02 ns** |  **52.24 ns** | **0.0012** |     **104 B** |
| **SystemTextJson**          | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **972.50 ns** | **4.133 ns** | **0.227 ns** | **972.24 ns** | **972.66 ns** |      **-** |     **104 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Gn(...)&quot;:0} [182] | 934.19 ns | 8.205 ns | 0.450 ns | 933.68 ns | 934.53 ns |      - |     104 B |
