```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,225.0 ns** |    **126.30 ns** |     **6.92 ns** |     **1,217.6 ns** |     **1,231.2 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,369.0 ns |    301.14 ns |    16.51 ns |     1,356.6 ns |     1,387.7 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,618.4 ns |    139.71 ns |     7.66 ns |     1,612.5 ns |     1,627.0 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,610.0 ns |    343.54 ns |    18.83 ns |     2,594.1 ns |     2,630.8 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       199.7 ns |     15.69 ns |     0.86 ns |       198.8 ns |       200.5 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       291.6 ns |     15.78 ns |     0.86 ns |       290.9 ns |       292.5 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       510.7 ns |     71.29 ns |     3.91 ns |       508.2 ns |       515.2 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,553,788.8 ns** |  **3,800.47 ns** |   **208.32 ns** | **1,553,597.9 ns** | **1,554,011.0 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,483.1 ns |  1,690.26 ns |    92.65 ns |   617,388.3 ns |   617,573.5 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,635.0 ns | 21,610.87 ns | 1,184.56 ns |   658,476.9 ns |   660,844.4 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,380,712.0 ns | 36,880.66 ns | 2,021.55 ns | 1,379,202.8 ns | 1,383,008.8 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,587.3 ns | 12,826.73 ns |   703.08 ns |   163,153.0 ns |   164,398.4 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    93,116.5 ns |  9,853.14 ns |   540.08 ns |    92,775.7 ns |    93,739.2 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,765.5 ns |  4,394.90 ns |   240.90 ns |    65,616.5 ns |    66,043.4 ns |      - |      40 B |
