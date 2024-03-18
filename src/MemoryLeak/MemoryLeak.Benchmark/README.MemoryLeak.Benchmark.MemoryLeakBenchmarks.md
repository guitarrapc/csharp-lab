```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **787.7 ns** |   **543.8 ns** | **29.81 ns** |   **759.5 ns** |   **818.9 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   724.3 ns |   273.2 ns | 14.97 ns |   715.5 ns |   741.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   714.1 ns |   601.7 ns | 32.98 ns |   694.4 ns |   752.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   746.6 ns |   562.3 ns | 30.82 ns |   715.1 ns |   776.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   757.1 ns |   112.2 ns |  6.15 ns |   750.0 ns |   761.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,355.8 ns** | **1,588.7 ns** | **87.08 ns** | **2,258.7 ns** | **2,427.0 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,163.5 ns |   818.6 ns | 44.87 ns | 2,133.1 ns | 2,215.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,154.8 ns | 1,074.9 ns | 58.92 ns | 2,117.9 ns | 2,222.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,219.9 ns |   229.8 ns | 12.60 ns | 2,206.3 ns | 2,231.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,167.3 ns |   428.4 ns | 23.48 ns | 2,148.4 ns | 2,193.6 ns | 0.0343 | 0.0305 |   3.07 KB |
