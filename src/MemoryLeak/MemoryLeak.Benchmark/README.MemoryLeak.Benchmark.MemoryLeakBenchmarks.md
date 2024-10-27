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
| **AllocateStringStatic** | **1**      |   **752.5 ns** |   **595.8 ns** | **32.66 ns** |   **728.4 ns** |   **789.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   737.2 ns |   307.0 ns | 16.83 ns |   719.8 ns |   753.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   727.0 ns |   329.9 ns | 18.09 ns |   709.0 ns |   745.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   734.8 ns |   371.1 ns | 20.34 ns |   712.8 ns |   752.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   726.3 ns |   329.9 ns | 18.08 ns |   705.6 ns |   739.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,256.7 ns** |   **728.1 ns** | **39.91 ns** | **2,211.8 ns** | **2,288.1 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,146.3 ns | 1,367.6 ns | 74.96 ns | 2,099.1 ns | 2,232.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,087.6 ns | 1,247.2 ns | 68.36 ns | 2,009.8 ns | 2,137.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,162.7 ns | 1,362.4 ns | 74.68 ns | 2,086.0 ns | 2,235.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,189.5 ns |   981.6 ns | 53.81 ns | 2,129.4 ns | 2,233.2 ns | 0.0343 | 0.0305 |   3.07 KB |
