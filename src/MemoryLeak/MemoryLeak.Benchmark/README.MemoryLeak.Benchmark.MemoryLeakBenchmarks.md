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
| **AllocateStringStatic** | **1**      |   **748.5 ns** |   **317.0 ns** | **17.38 ns** |   **734.5 ns** |   **767.9 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   715.3 ns |   360.5 ns | 19.76 ns |   698.1 ns |   736.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   707.6 ns |   201.4 ns | 11.04 ns |   698.8 ns |   720.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   750.3 ns |   541.2 ns | 29.67 ns |   716.0 ns |   768.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   717.1 ns |   307.9 ns | 16.88 ns |   701.1 ns |   734.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,277.8 ns** | **1,625.3 ns** | **89.09 ns** | **2,174.9 ns** | **2,329.5 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,163.1 ns | 1,596.6 ns | 87.51 ns | 2,069.5 ns | 2,242.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,079.2 ns |   773.7 ns | 42.41 ns | 2,054.6 ns | 2,128.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,147.2 ns |   644.6 ns | 35.33 ns | 2,117.4 ns | 2,186.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,183.1 ns | 1,532.9 ns | 84.02 ns | 2,088.1 ns | 2,247.6 ns | 0.0343 | 0.0305 |   3.07 KB |
