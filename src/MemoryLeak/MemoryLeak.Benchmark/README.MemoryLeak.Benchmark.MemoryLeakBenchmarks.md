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
| **AllocateStringStatic** | **1**      |   **776.8 ns** |   **628.1 ns** | **34.43 ns** |   **739.5 ns** |   **807.3 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   819.8 ns | 1,257.5 ns | 68.93 ns |   740.5 ns |   865.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   710.9 ns |   425.4 ns | 23.32 ns |   691.4 ns |   736.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   844.3 ns |   188.3 ns | 10.32 ns |   832.6 ns |   852.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   743.5 ns |   494.1 ns | 27.08 ns |   712.5 ns |   762.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,474.1 ns** | **1,448.7 ns** | **79.41 ns** | **2,382.8 ns** | **2,527.2 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,204.0 ns |   810.1 ns | 44.40 ns | 2,153.2 ns | 2,235.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,071.9 ns | 1,434.5 ns | 78.63 ns | 1,998.8 ns | 2,155.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,355.0 ns | 1,014.3 ns | 55.60 ns | 2,305.1 ns | 2,414.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,141.3 ns |   953.1 ns | 52.24 ns | 2,081.7 ns | 2,179.1 ns | 0.0343 | 0.0305 |   3.07 KB |
