```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data      | json                 | Mean      | Error      | StdDev    | Min       | Max      | Gen0   | Allocated |
|------------------------ |---------- |--------------------- |----------:|-----------:|----------:|----------:|---------:|-------:|----------:|
| **MemoryPack**              | **Byte[103]** | **?**                    |  **96.91 ns** |  **50.636 ns** |  **2.776 ns** |  **95.26 ns** | **100.1 ns** | **0.0029** |     **248 B** |
| **SystemTextJson**          | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **622.75 ns** |   **5.208 ns** |  **0.285 ns** | **622.55 ns** | **623.1 ns** | **0.0029** |     **248 B** |
| SystemTextJsonSourceGen | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 614.00 ns | 291.258 ns | 15.965 ns | 604.76 ns | 632.4 ns | 0.0029 |     248 B |
