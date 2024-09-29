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
| **AllocateStringStatic** | **1**      |   **754.7 ns** |   **772.1 ns** |  **42.32 ns** |   **705.9 ns** |   **780.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   734.5 ns |   604.4 ns |  33.13 ns |   696.3 ns |   754.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   717.2 ns |   645.1 ns |  35.36 ns |   681.1 ns |   751.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   725.4 ns |   910.5 ns |  49.91 ns |   692.8 ns |   782.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   724.3 ns |   812.1 ns |  44.51 ns |   679.1 ns |   768.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,224.9 ns** | **2,140.4 ns** | **117.32 ns** | **2,129.3 ns** | **2,355.8 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,065.0 ns |   239.6 ns |  13.14 ns | 2,052.9 ns | 2,079.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,063.6 ns | 2,815.5 ns | 154.33 ns | 1,946.4 ns | 2,238.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,207.4 ns | 2,106.0 ns | 115.44 ns | 2,074.1 ns | 2,275.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,251.4 ns |   422.5 ns |  23.16 ns | 2,226.0 ns | 2,271.4 ns | 0.0343 | 0.0305 |   3.07 KB |
