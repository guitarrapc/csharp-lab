```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **753.5 ns** |   **514.7 ns** | **28.21 ns** |   **729.5 ns** |   **784.5 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   728.4 ns |   333.5 ns | 18.28 ns |   709.5 ns |   746.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   711.6 ns |   552.0 ns | 30.26 ns |   676.7 ns |   730.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   743.4 ns |   351.1 ns | 19.24 ns |   725.9 ns |   764.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   744.5 ns |   327.9 ns | 17.97 ns |   723.9 ns |   756.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,230.7 ns** | **1,514.3 ns** | **83.01 ns** | **2,180.5 ns** | **2,326.5 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,176.6 ns | 1,396.4 ns | 76.54 ns | 2,090.8 ns | 2,237.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,151.5 ns | 1,747.6 ns | 95.79 ns | 2,046.8 ns | 2,234.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,252.1 ns | 1,650.9 ns | 90.49 ns | 2,164.5 ns | 2,345.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,151.8 ns | 1,107.2 ns | 60.69 ns | 2,081.8 ns | 2,189.7 ns | 0.0343 | 0.0305 |   3.07 KB |
