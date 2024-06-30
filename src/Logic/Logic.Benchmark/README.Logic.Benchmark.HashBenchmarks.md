```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,305.8 ns** |    **118.54 ns** |     **6.50 ns** |     **1,298.7 ns** |     **1,311.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,463.1 ns |     50.12 ns |     2.75 ns |     1,460.1 ns |     1,465.6 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,721.9 ns |    257.05 ns |    14.09 ns |     1,711.3 ns |     1,737.9 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,696.6 ns |  1,078.57 ns |    59.12 ns |     2,653.7 ns |     2,764.1 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       204.0 ns |     55.89 ns |     3.06 ns |       201.5 ns |       207.4 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       281.0 ns |     28.17 ns |     1.54 ns |       280.0 ns |       282.7 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       494.1 ns |     56.54 ns |     3.10 ns |       491.9 ns |       497.6 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,203.0 ns** |  **3,628.25 ns** |   **198.88 ns** | **1,544,981.8 ns** | **1,545,367.1 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,240.6 ns |  3,318.26 ns |   181.88 ns |   614,039.1 ns |   614,392.5 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,848.2 ns | 23,253.74 ns | 1,274.62 ns |   654,996.0 ns |   657,313.5 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,372,350.7 ns |  1,525.82 ns |    83.64 ns | 1,372,275.8 ns | 1,372,440.9 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,192.5 ns |    408.50 ns |    22.39 ns |   162,172.1 ns |   162,216.5 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,626.1 ns |  2,304.78 ns |   126.33 ns |    92,537.7 ns |    92,770.8 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,374.8 ns |  6,681.10 ns |   366.21 ns |    64,955.3 ns |    65,630.4 ns |      - |      40 B |
