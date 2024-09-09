```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **765.1 ns** |   **466.7 ns** | **25.58 ns** |   **740.1 ns** |   **791.2 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   722.6 ns |   514.9 ns | 28.23 ns |   694.0 ns |   750.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   708.6 ns |   389.1 ns | 21.33 ns |   684.4 ns |   724.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   752.0 ns |   133.3 ns |  7.30 ns |   746.8 ns |   760.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   754.0 ns |   479.0 ns | 26.26 ns |   732.2 ns |   783.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,195.6 ns** | **1,335.5 ns** | **73.20 ns** | **2,129.9 ns** | **2,274.5 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,244.3 ns | 1,261.9 ns | 69.17 ns | 2,200.9 ns | 2,324.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,052.7 ns |   946.1 ns | 51.86 ns | 2,003.3 ns | 2,106.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,165.4 ns |   756.2 ns | 41.45 ns | 2,119.2 ns | 2,199.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,161.3 ns | 1,626.1 ns | 89.13 ns | 2,060.0 ns | 2,227.7 ns | 0.0343 | 0.0305 |   3.07 KB |
