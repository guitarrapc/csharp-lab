```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **783.7 ns** |   **225.5 ns** | **12.36 ns** |   **770.3 ns** |   **794.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   726.1 ns |   925.2 ns | 50.71 ns |   692.9 ns |   784.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   735.0 ns |   180.3 ns |  9.89 ns |   728.8 ns |   746.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   757.4 ns |   528.8 ns | 28.99 ns |   725.3 ns |   781.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   753.5 ns |   136.0 ns |  7.45 ns |   747.3 ns |   761.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,255.1 ns** | **1,280.3 ns** | **70.18 ns** | **2,175.8 ns** | **2,309.2 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,128.5 ns | 1,555.9 ns | 85.28 ns | 2,075.6 ns | 2,226.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,199.4 ns | 1,645.9 ns | 90.22 ns | 2,117.2 ns | 2,295.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,267.6 ns | 1,584.7 ns | 86.86 ns | 2,174.7 ns | 2,346.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,142.2 ns | 1,695.6 ns | 92.94 ns | 2,085.3 ns | 2,249.5 ns | 0.0343 | 0.0305 |   3.07 KB |
