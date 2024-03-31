```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean      | Error        | StdDev    | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |----------:|-------------:|----------:|----------:|------------:|-------:|----------:|
| **MemoryPack**              | **Byte[89]** | **?**                   |  **58.44 ns** |     **2.289 ns** |  **0.125 ns** |  **58.31 ns** |    **58.57 ns** | **0.0012** |     **104 B** |
| **SystemTextJson**          | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **992.20 ns** |   **778.515 ns** | **42.673 ns** | **966.37 ns** | **1,041.45 ns** |      **-** |     **104 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Gn(...)&quot;:0} [182] | 999.93 ns | 1,112.345 ns | 60.971 ns | 954.36 ns | 1,069.19 ns |      - |     104 B |
