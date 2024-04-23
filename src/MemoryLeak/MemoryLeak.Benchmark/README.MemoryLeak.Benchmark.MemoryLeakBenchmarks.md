```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **765.8 ns** |   **377.8 ns** | **20.71 ns** |   **742.0 ns** |   **779.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   727.2 ns |   435.7 ns | 23.88 ns |   709.0 ns |   754.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   725.9 ns |   332.6 ns | 18.23 ns |   707.4 ns |   743.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   750.7 ns |   334.9 ns | 18.36 ns |   731.3 ns |   767.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   749.7 ns |   202.7 ns | 11.11 ns |   737.5 ns |   759.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,287.9 ns** |   **986.0 ns** | **54.04 ns** | **2,228.2 ns** | **2,333.6 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,208.9 ns | 1,581.0 ns | 86.66 ns | 2,123.7 ns | 2,297.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,123.2 ns | 1,301.5 ns | 71.34 ns | 2,043.4 ns | 2,180.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,186.5 ns | 1,641.4 ns | 89.97 ns | 2,099.2 ns | 2,279.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,197.8 ns |   618.4 ns | 33.89 ns | 2,171.5 ns | 2,236.1 ns | 0.0343 | 0.0305 |   3.07 KB |
