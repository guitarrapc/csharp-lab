```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean        | Error     | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |------------:|----------:|----------:|------------:|------------:|-------:|----------:|
| **MemoryPack**              | **Byte[89]** | **?**                   |    **58.06 ns** |  **10.93 ns** |  **0.599 ns** |    **57.40 ns** |    **58.57 ns** | **0.0012** |     **104 B** |
| **SystemTextJson**          | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **1,026.30 ns** | **116.70 ns** |  **6.397 ns** | **1,018.92 ns** | **1,030.27 ns** |      **-** |     **104 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Gn(...)&quot;:0} [182] | 1,045.82 ns | 489.40 ns | 26.825 ns | 1,023.29 ns | 1,075.50 ns |      - |     104 B |
