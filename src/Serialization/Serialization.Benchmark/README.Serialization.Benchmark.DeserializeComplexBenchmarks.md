```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean      | Error      | StdDev    | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |----------:|-----------:|----------:|----------:|------------:|-------:|----------:|
| **MemoryPack**              | **Byte[89]** | **?**                   |  **54.86 ns** |  **20.281 ns** |  **1.112 ns** |  **53.58 ns** |    **55.59 ns** | **0.0012** |     **104 B** |
| **SystemTextJson**          | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **963.90 ns** |   **9.969 ns** |  **0.546 ns** | **963.44 ns** |   **964.50 ns** |      **-** |     **104 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Gn(...)&quot;:0} [182] | 980.24 ns | 439.397 ns | 24.085 ns | 955.35 ns | 1,003.43 ns |      - |     104 B |
