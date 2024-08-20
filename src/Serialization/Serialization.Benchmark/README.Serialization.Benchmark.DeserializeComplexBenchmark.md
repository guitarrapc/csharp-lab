```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean        | Error        | StdDev    | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |------------:|-------------:|----------:|----------:|------------:|-------:|----------:|
| **MemoryPack**              | **Byte[89]** | **?**                   |    **59.13 ns** |     **4.946 ns** |  **0.271 ns** |  **58.84 ns** |    **59.38 ns** | **0.0012** |     **104 B** |
| **SystemTextJson**          | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **1,020.19 ns** | **1,023.996 ns** | **56.129 ns** | **987.37 ns** | **1,085.00 ns** |      **-** |     **104 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Gn(...)&quot;:0} [182] |   950.26 ns |   176.691 ns |  9.685 ns | 943.53 ns |   961.36 ns |      - |     104 B |
