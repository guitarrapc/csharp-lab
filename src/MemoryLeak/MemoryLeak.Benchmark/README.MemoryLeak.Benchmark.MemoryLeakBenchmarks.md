```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **768.5 ns** |   **317.7 ns** | **17.42 ns** |   **756.1 ns** |   **788.4 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   752.4 ns |   184.6 ns | 10.12 ns |   744.0 ns |   763.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   720.4 ns |   438.6 ns | 24.04 ns |   694.5 ns |   742.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   746.8 ns |   362.1 ns | 19.85 ns |   724.1 ns |   760.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   723.2 ns |   381.5 ns | 20.91 ns |   701.5 ns |   743.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,271.4 ns** | **1,630.0 ns** | **89.35 ns** | **2,188.0 ns** | **2,365.7 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,208.5 ns |   349.6 ns | 19.16 ns | 2,191.1 ns | 2,229.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,102.8 ns |   790.3 ns | 43.32 ns | 2,054.1 ns | 2,137.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,208.9 ns |   769.3 ns | 42.17 ns | 2,160.2 ns | 2,233.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,150.7 ns |   870.0 ns | 47.69 ns | 2,111.6 ns | 2,203.8 ns | 0.0343 | 0.0305 |   3.07 KB |
