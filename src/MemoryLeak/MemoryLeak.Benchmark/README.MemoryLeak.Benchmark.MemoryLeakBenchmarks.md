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
| **AllocateStringStatic** | **1**      |   **744.8 ns** |   **159.7 ns** |   **8.75 ns** |   **738.4 ns** |   **754.8 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   725.5 ns |   484.4 ns |  26.55 ns |   697.4 ns |   750.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   714.6 ns |   410.8 ns |  22.52 ns |   693.8 ns |   738.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   742.2 ns |   327.4 ns |  17.94 ns |   721.8 ns |   755.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   725.2 ns |   612.5 ns |  33.57 ns |   687.1 ns |   750.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,744.3 ns** | **7,258.5 ns** | **397.86 ns** | **7,297.2 ns** | **8,059.3 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,273.8 ns | 1,831.7 ns | 100.40 ns | 7,158.0 ns | 7,336.4 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,118.9 ns | 2,354.2 ns | 129.04 ns | 7,001.3 ns | 7,256.9 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,321.1 ns | 2,961.2 ns | 162.32 ns | 7,220.6 ns | 7,508.4 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,419.8 ns | 1,313.4 ns |  71.99 ns | 7,344.5 ns | 7,487.9 ns | 0.1221 | 0.1144 |  10.23 KB |
