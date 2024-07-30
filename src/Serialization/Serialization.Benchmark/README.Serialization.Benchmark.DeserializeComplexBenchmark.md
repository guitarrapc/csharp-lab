```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **Byte[89]** | **?**                   |  **56.65 ns** |   **1.989 ns** | **0.109 ns** |  **56.53 ns** |  **56.74 ns** | **0.0012** |     **104 B** |
| **SystemTextJson**          | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **985.97 ns** | **120.468 ns** | **6.603 ns** | **981.48 ns** | **993.55 ns** |      **-** |     **104 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Gn(...)&quot;:0} [182] | 950.55 ns |  54.292 ns | 2.976 ns | 948.09 ns | 953.86 ns |      - |     104 B |
