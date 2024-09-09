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
| **AllocateStringStatic** | **1**      |   **737.5 ns** |   **498.4 ns** | **27.32 ns** |   **706.4 ns** |   **757.9 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   713.7 ns |   330.4 ns | 18.11 ns |   692.9 ns |   726.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   688.2 ns |   353.7 ns | 19.39 ns |   667.4 ns |   705.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   746.9 ns |   242.4 ns | 13.28 ns |   732.3 ns |   758.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   719.9 ns |   126.1 ns |  6.91 ns |   712.4 ns |   726.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,233.3 ns** | **1,749.0 ns** | **95.87 ns** | **2,138.5 ns** | **2,330.2 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,133.5 ns |   422.7 ns | 23.17 ns | 2,120.0 ns | 2,160.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,087.6 ns |   572.3 ns | 31.37 ns | 2,065.8 ns | 2,123.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,161.0 ns | 1,175.0 ns | 64.41 ns | 2,089.0 ns | 2,213.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,100.5 ns |   750.6 ns | 41.14 ns | 2,053.1 ns | 2,126.7 ns | 0.0343 | 0.0305 |   3.07 KB |
