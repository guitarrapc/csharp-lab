```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **Byte[89]** | **?**                   |  **54.97 ns** |   **1.203 ns** | **0.066 ns** |  **54.91 ns** |  **55.04 ns** | **0.0012** |     **104 B** |
| **SystemTextJson**          | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **968.85 ns** | **111.198 ns** | **6.095 ns** | **964.88 ns** | **975.87 ns** |      **-** |     **104 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Gn(...)&quot;:0} [182] | 966.28 ns |  91.480 ns | 5.014 ns | 960.52 ns | 969.64 ns |      - |     104 B |
