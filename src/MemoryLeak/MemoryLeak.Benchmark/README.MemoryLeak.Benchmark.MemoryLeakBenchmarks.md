```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **744.4 ns** |   **303.53 ns** |  **16.64 ns** |   **725.2 ns** |   **754.2 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   709.7 ns |    14.04 ns |   0.77 ns |   709.3 ns |   710.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   698.9 ns |   578.52 ns |  31.71 ns |   670.1 ns |   732.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   722.1 ns |   169.48 ns |   9.29 ns |   711.4 ns |   728.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   711.2 ns |   676.97 ns |  37.11 ns |   684.1 ns |   753.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,193.3 ns** |   **478.12 ns** |  **26.21 ns** | **2,163.1 ns** | **2,209.6 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,198.7 ns | 1,976.12 ns | 108.32 ns | 2,082.2 ns | 2,296.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,097.2 ns | 1,140.45 ns |  62.51 ns | 2,025.4 ns | 2,139.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,230.1 ns | 1,536.67 ns |  84.23 ns | 2,135.4 ns | 2,296.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,123.3 ns |   863.84 ns |  47.35 ns | 2,068.9 ns | 2,154.7 ns | 0.0343 | 0.0305 |   3.07 KB |
