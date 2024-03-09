```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **771.9 ns** |   **697.9 ns** |  **38.25 ns** |   **728.4 ns** |   **800.2 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   755.2 ns |   322.3 ns |  17.67 ns |   739.8 ns |   774.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   721.9 ns |   423.8 ns |  23.23 ns |   701.3 ns |   747.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   748.9 ns |   242.1 ns |  13.27 ns |   736.0 ns |   762.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   767.3 ns |   304.5 ns |  16.69 ns |   750.7 ns |   784.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,232.9 ns** | **1,146.3 ns** |  **62.83 ns** | **2,167.9 ns** | **2,293.3 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,246.8 ns |   379.9 ns |  20.82 ns | 2,225.1 ns | 2,266.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,150.9 ns |   846.5 ns |  46.40 ns | 2,102.2 ns | 2,194.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,194.5 ns | 2,025.3 ns | 111.02 ns | 2,127.9 ns | 2,322.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,228.5 ns |   692.8 ns |  37.98 ns | 2,206.0 ns | 2,272.3 ns | 0.0343 | 0.0305 |   3.07 KB |
