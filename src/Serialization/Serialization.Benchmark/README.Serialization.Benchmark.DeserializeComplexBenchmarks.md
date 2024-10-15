```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean      | Error      | StdDev    | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |----------:|-----------:|----------:|----------:|------------:|-------:|----------:|
| **MemoryPack**              | **Byte[89]** | **?**                   |  **53.47 ns** |   **5.310 ns** |  **0.291 ns** |  **53.19 ns** |    **53.77 ns** | **0.0012** |     **104 B** |
| **SystemTextJson**          | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **999.32 ns** | **480.612 ns** | **26.344 ns** | **980.83 ns** | **1,029.48 ns** |      **-** |     **104 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Gn(...)&quot;:0} [182] | 966.70 ns | 813.515 ns | 44.592 ns | 940.73 ns | 1,018.19 ns |      - |     104 B |
