```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **MemoryPack**              | **Byte[89]** | **?**                   |    **61.19 ns** |   **9.833 ns** | **0.539 ns** |    **60.64 ns** |    **61.72 ns** | **0.0012** |     **104 B** |
| **SystemTextJson**          | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **1,009.53 ns** | **111.394 ns** | **6.106 ns** | **1,003.21 ns** | **1,015.39 ns** |      **-** |     **104 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Gn(...)&quot;:0} [182] | 1,016.34 ns | 107.845 ns | 5.911 ns | 1,010.13 ns | 1,021.90 ns |      - |     104 B |
