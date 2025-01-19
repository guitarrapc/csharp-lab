```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,213.7 ns** |      **57.68 ns** |     **3.16 ns** |     **1,210.6 ns** |     **1,216.9 ns** | **0.0668** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,433.0 ns |     211.15 ns |    11.57 ns |     1,420.8 ns |     1,443.8 ns | 0.0839 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,639.6 ns |      86.48 ns |     4.74 ns |     1,636.7 ns |     1,645.1 ns | 0.1106 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,572.4 ns |     251.04 ns |    13.76 ns |     2,556.6 ns |     2,582.1 ns | 0.1907 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       175.5 ns |      16.44 ns |     0.90 ns |       174.6 ns |       176.4 ns | 0.0348 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       253.7 ns |      29.78 ns |     1.63 ns |       251.8 ns |       254.8 ns | 0.0434 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       476.0 ns |      81.27 ns |     4.45 ns |       472.8 ns |       481.1 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,553,864.0 ns** |   **9,883.02 ns** |   **541.72 ns** | **1,553,398.8 ns** | **1,554,458.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,332.8 ns |   4,966.91 ns |   272.25 ns |   617,132.8 ns |   617,642.9 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   660,211.1 ns |  12,729.88 ns |   697.77 ns |   659,410.5 ns |   660,689.5 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,385,518.4 ns | 178,037.96 ns | 9,758.86 ns | 1,379,289.8 ns | 1,396,765.3 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,050.3 ns |   3,874.71 ns |   212.39 ns |   162,926.8 ns |   163,295.5 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,279.6 ns |   6,195.31 ns |   339.59 ns |    92,048.0 ns |    92,669.4 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    33,040.5 ns |   2,073.68 ns |   113.67 ns |    32,952.6 ns |    33,168.9 ns |      - |      40 B |
