```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **767.9 ns** |   **284.4 ns** | **15.59 ns** |   **752.5 ns** |   **783.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   727.2 ns |   155.4 ns |  8.52 ns |   717.4 ns |   732.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   713.9 ns |   577.3 ns | 31.64 ns |   682.3 ns |   745.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   738.3 ns |   529.4 ns | 29.02 ns |   720.7 ns |   771.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   725.9 ns |   273.5 ns | 14.99 ns |   708.6 ns |   735.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,243.2 ns** |   **441.4 ns** | **24.20 ns** | **2,216.6 ns** | **2,263.8 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,155.6 ns |   909.4 ns | 49.85 ns | 2,100.5 ns | 2,197.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,106.0 ns | 1,210.6 ns | 66.36 ns | 2,030.5 ns | 2,154.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,185.4 ns |   594.6 ns | 32.59 ns | 2,148.1 ns | 2,208.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,111.8 ns |   826.9 ns | 45.33 ns | 2,069.0 ns | 2,159.3 ns | 0.0343 | 0.0305 |   3.07 KB |
