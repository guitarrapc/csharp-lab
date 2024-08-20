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
| **AllocateStringStatic** | **1**      |   **752.8 ns** |   **627.6 ns** | **34.40 ns** |   **714.9 ns** |   **782.1 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   747.9 ns |   330.7 ns | 18.13 ns |   727.0 ns |   759.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   713.4 ns |   242.8 ns | 13.31 ns |   698.4 ns |   723.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   733.2 ns |   566.5 ns | 31.05 ns |   703.4 ns |   765.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   715.3 ns |   543.5 ns | 29.79 ns |   688.5 ns |   747.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,227.3 ns** | **1,638.0 ns** | **89.79 ns** | **2,174.1 ns** | **2,330.9 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,215.5 ns |   618.1 ns | 33.88 ns | 2,193.8 ns | 2,254.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,165.6 ns | 1,790.0 ns | 98.12 ns | 2,062.7 ns | 2,258.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,167.0 ns | 1,438.2 ns | 78.83 ns | 2,107.4 ns | 2,256.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,149.8 ns |   113.6 ns |  6.23 ns | 2,143.2 ns | 2,155.6 ns | 0.0343 | 0.0305 |   3.07 KB |
