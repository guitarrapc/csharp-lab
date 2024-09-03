```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **MemoryPack**              | **Byte[91]** | **?**                   |    **88.69 ns** |   **9.128 ns** |  **0.500 ns** |    **88.29 ns** |    **89.25 ns** | **0.0019** |     **168 B** |
| **SystemTextJson**          | **?**        | **{&quot;Sh(...)22&quot;} [220]** | **1,221.65 ns** |  **16.487 ns** |  **0.904 ns** | **1,221.09 ns** | **1,222.70 ns** | **0.0019** |     **168 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Sh(...)22&quot;} [220] | 1,214.54 ns | 650.756 ns | 35.670 ns | 1,189.92 ns | 1,255.45 ns | 0.0019 |     168 B |
