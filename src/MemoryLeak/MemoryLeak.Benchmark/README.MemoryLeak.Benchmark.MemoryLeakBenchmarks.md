```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **751.5 ns** |   **374.1 ns** |  **20.51 ns** |   **727.9 ns** |   **764.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   732.6 ns |   315.3 ns |  17.28 ns |   714.4 ns |   748.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   722.8 ns |   552.1 ns |  30.26 ns |   689.2 ns |   747.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   762.6 ns |   469.8 ns |  25.75 ns |   733.2 ns |   781.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   714.4 ns |   542.4 ns |  29.73 ns |   696.9 ns |   748.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,234.1 ns** | **1,341.5 ns** |  **73.53 ns** | **2,154.0 ns** | **2,298.5 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,141.7 ns | 1,485.0 ns |  81.40 ns | 2,069.2 ns | 2,229.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,063.4 ns |   852.6 ns |  46.74 ns | 2,012.3 ns | 2,104.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,173.8 ns |   567.8 ns |  31.12 ns | 2,143.1 ns | 2,205.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,239.1 ns | 3,746.1 ns | 205.34 ns | 2,042.9 ns | 2,452.5 ns | 0.0343 | 0.0305 |   3.07 KB |
