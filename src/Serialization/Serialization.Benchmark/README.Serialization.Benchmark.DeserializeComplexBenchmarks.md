```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **Byte[89]** | **?**                   |  **53.78 ns** |   **0.977 ns** |  **0.054 ns** |  **53.74 ns** |  **53.84 ns** | **0.0012** |     **104 B** |
| **SystemTextJson**          | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **955.09 ns** | **250.021 ns** | **13.704 ns** | **946.68 ns** | **970.90 ns** |      **-** |     **104 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Gn(...)&quot;:0} [182] | 959.95 ns | 237.118 ns | 12.997 ns | 947.52 ns | 973.45 ns |      - |     104 B |
