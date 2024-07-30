```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **750.8 ns** |   **315.4 ns** | **17.29 ns** |   **734.2 ns** |   **768.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   727.2 ns |   191.9 ns | 10.52 ns |   719.3 ns |   739.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   706.5 ns |   447.2 ns | 24.51 ns |   679.5 ns |   727.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   736.6 ns |   171.6 ns |  9.41 ns |   730.8 ns |   747.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   723.7 ns |   223.1 ns | 12.23 ns |   709.6 ns |   731.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,190.0 ns** |   **912.5 ns** | **50.02 ns** | **2,137.7 ns** | **2,237.4 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,135.3 ns | 1,285.6 ns | 70.47 ns | 2,054.3 ns | 2,182.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,115.0 ns | 1,761.7 ns | 96.56 ns | 2,004.0 ns | 2,179.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,152.2 ns |   716.2 ns | 39.26 ns | 2,123.2 ns | 2,196.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,072.9 ns |   984.5 ns | 53.96 ns | 2,023.3 ns | 2,130.4 ns | 0.0343 | 0.0305 |   3.07 KB |
