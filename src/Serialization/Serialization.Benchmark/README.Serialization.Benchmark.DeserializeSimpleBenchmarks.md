```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data      | json                 | Mean      | Error     | StdDev   | Min       | Max      | Gen0   | Allocated |
|------------------------ |---------- |--------------------- |----------:|----------:|---------:|----------:|---------:|-------:|----------:|
| **MemoryPack**              | **Byte[103]** | **?**                    |  **97.01 ns** | **48.010 ns** | **2.632 ns** |  **95.28 ns** | **100.0 ns** | **0.0029** |     **248 B** |
| **SystemTextJson**          | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **616.33 ns** | **12.899 ns** | **0.707 ns** | **615.75 ns** | **617.1 ns** | **0.0029** |     **248 B** |
| SystemTextJsonSourceGen | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 582.12 ns |  4.425 ns | 0.243 ns | 581.89 ns | 582.4 ns | 0.0029 |     248 B |
