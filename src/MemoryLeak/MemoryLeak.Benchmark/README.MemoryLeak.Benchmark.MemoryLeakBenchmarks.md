```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **774.4 ns** |   **556.5 ns** |  **30.50 ns** |   **739.2 ns** |   **793.2 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   752.4 ns |   775.1 ns |  42.48 ns |   705.1 ns |   787.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   728.9 ns |   698.7 ns |  38.30 ns |   687.1 ns |   762.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   768.6 ns |   271.9 ns |  14.90 ns |   757.3 ns |   785.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   731.6 ns |   424.5 ns |  23.27 ns |   704.8 ns |   746.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,312.7 ns** | **1,804.6 ns** |  **98.92 ns** | **2,199.0 ns** | **2,378.7 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,197.5 ns | 2,765.8 ns | 151.60 ns | 2,026.7 ns | 2,315.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,127.4 ns | 2,032.3 ns | 111.40 ns | 2,025.7 ns | 2,246.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,170.2 ns | 1,968.2 ns | 107.88 ns | 2,074.3 ns | 2,287.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,104.1 ns | 2,496.5 ns | 136.84 ns | 2,022.0 ns | 2,262.0 ns | 0.0343 | 0.0305 |   3.07 KB |
