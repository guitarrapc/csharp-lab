```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **765.7 ns** |   **370.5 ns** | **20.31 ns** |   **752.2 ns** |   **789.0 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   728.8 ns |   248.0 ns | 13.60 ns |   713.5 ns |   739.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   699.7 ns |   594.7 ns | 32.60 ns |   679.1 ns |   737.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   764.4 ns | 1,022.6 ns | 56.05 ns |   728.9 ns |   829.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   755.2 ns |   536.8 ns | 29.42 ns |   721.9 ns |   777.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,280.1 ns** | **1,228.8 ns** | **67.35 ns** | **2,238.7 ns** | **2,357.8 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,260.2 ns | 1,747.8 ns | 95.80 ns | 2,192.9 ns | 2,369.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,229.2 ns |   721.5 ns | 39.55 ns | 2,184.4 ns | 2,259.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,206.1 ns | 1,120.2 ns | 61.40 ns | 2,137.6 ns | 2,256.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,183.6 ns |   439.7 ns | 24.10 ns | 2,159.1 ns | 2,207.3 ns | 0.0343 | 0.0305 |   3.07 KB |
