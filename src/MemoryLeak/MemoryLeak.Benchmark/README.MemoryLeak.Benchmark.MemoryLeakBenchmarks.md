```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **777.6 ns** |   **234.5 ns** |  **12.85 ns** |   **768.9 ns** |   **792.4 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   740.7 ns |   181.7 ns |   9.96 ns |   731.4 ns |   751.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   723.9 ns |   343.2 ns |  18.81 ns |   702.6 ns |   738.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   746.7 ns |   822.4 ns |  45.08 ns |   716.8 ns |   798.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   734.9 ns |   275.2 ns |  15.09 ns |   717.5 ns |   744.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,223.3 ns** | **1,741.1 ns** |  **95.44 ns** | **2,140.6 ns** | **2,327.7 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,187.0 ns |   703.0 ns |  38.54 ns | 2,157.1 ns | 2,230.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,191.2 ns | 1,168.3 ns |  64.04 ns | 2,138.3 ns | 2,262.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,289.2 ns |   195.8 ns |  10.73 ns | 2,279.6 ns | 2,300.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,173.8 ns | 2,043.9 ns | 112.03 ns | 2,097.9 ns | 2,302.5 ns | 0.0343 | 0.0305 |   3.07 KB |
